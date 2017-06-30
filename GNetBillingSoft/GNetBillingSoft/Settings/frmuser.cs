using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
using System.Security.Cryptography;
namespace GNetBillingSoft.Settings
{
    public partial class frmuser : Form
    {
        MenuStrip mnu;
        clsuserinfo user = new clsuserinfo();
        clsuserroles roles = new clsuserroles();
        public frmuser(MenuStrip main)
        {
            InitializeComponent();

            mnu = main;
            MenuPrevilege();
            FillListBox();
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "New User (مستخدم جديد)";

            //Labels
            this.lblUsr.Text = "المستعمل";
            this.lblPswd.Text = "كلمه السر";
            this.grpUsrList.Text = "المستعمل";
            
            //Button
            this.btncreate.Text = "خلق";
            this.btndel.Text = "الغاء";
            this.btnclear.Text = "واضح";

            grpMenus.Text = "القائمة بريفيليجيس";
        }
        void MenuPrevilege(DataTable data=null)
        {
            
            foreach (ToolStripMenuItem   item  in mnu.Items)
            {

                TreeNode node ;
               
                
               node= trwMenu.Nodes.Add(item.Name,item.Text);
               if (data != null)
               {
                   for (int i = 0; i < data.Rows.Count; i++)
                   {
                       if (data.Rows[i]["menuname"].ToString() == item.Name)
                       {
                           trwMenu.Nodes[data.Rows[i]["menuname"].ToString()].Checked = true;
                       }
                   }
               }
                ChildMenu(item, node,data);
                
            }
        }

        void trw_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
                if (e.Node.Parent != null)
                {
                    ParentChecked(e.Node.Parent, e.Node.Checked);
                }
            }
        }

      
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively. 
                    this.CheckAllChildNodes(node, nodeChecked);
                }
              
            }
        }
        private void ParentChecked(TreeNode pnt,bool nodeChecked)
        {
            pnt.Checked = nodeChecked;

            if (pnt.Parent != null)
            {
                this.ParentChecked(pnt.Parent, nodeChecked);
            }

           
        }
        //void SubMenus(ToolStripMenuItem mnuitem, TreeView trw)
        //{

        //    foreach (ToolStripMenuItem item in mnuitem.DropDownItems)
        //    {
        //        TreeNode node;
        //        node = trw.Nodes.Add(item.Name, item.Text);

        //        ChildMenu(item, node);


        //    }
        //    trw.Dock = DockStyle.Fill;
        //    grop.Controls.Add(trw);
        //}
        TreeNode ChildMenu(ToolStripMenuItem mnuitem, TreeNode node=null,DataTable data=null)
        {
            
            foreach (ToolStripMenuItem  item in mnuitem.DropDownItems)
            {
                TreeNode childnode = new TreeNode();
                childnode.Name = item.Name;
                childnode.Text = item.Text;

                node.Nodes.Add(childnode);
                if (data != null)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        if (data.Rows[i]["menuname"].ToString() == item.Name)
                        {
                            node.Nodes[data.Rows[i]["menuname"].ToString()].Checked = true;
                        }
                    }
                }
                if (item.DropDownItems.Count > 0)
                {
                    ChildMenu(item, childnode,data);
                }
            }
            
            return node;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
                if (user.GetItems())
                {
                    user.Edit();
                }
                else
                {
                    user.Add();
                }
                
                Clear();
            }
        }
        private bool SetData()
        {
            try
            {
                if (Validation())
                {
                    MD5 md5hash = MD5.Create();
                    user.userid =(clsuserroles.UId!=0)?clsuserroles.UId: user.GetNextId();
                    user.username = txtuser.Text;
                    
                        user.password = user.Encrypt(txtpassword.Text,"12345!@#$%");
                    
                    
                    foreach (TreeView item in grpMenus.Controls)
                    {


                        SetNodeData(user.userid, item);


                    }
                }
                return true;
            }
            catch(Exception )
            {
                return false;
            }
            

        }
        private void SetNodeData(long userid,TreeView trnd=null,TreeNode nd=null)
        {
            try
            {
                TreeNodeCollection trcollection = (trnd != null) ? trnd.Nodes : nd.Nodes;
                if (trcollection.Count > 0)
                {
                    foreach (TreeNode tnode in trcollection)
                    {
                        if (tnode.Checked)
                        {
                            roles.userroleid = roles.GetNextId();
                            roles.userid = userid;
                            roles.menuname = tnode.Name;
                            roles.DeleteRole();
                            roles.Add();
                        }
                        if (tnode.Nodes.Count > 0)
                        {

                            SetNodeData(userid, null, tnode);
                        }
                    }
                }
            }
            catch (Exception )
            {
            }
        }
       
        private bool Validation()
        {
            if (txtuser.Text.Trim() == "")
            {
                errorUser.SetError(txtuser, "User Name is required");
                return false;
            }
            if (txtpassword.Text.Trim() == "")
            {
                errorUser.SetError(txtpassword, "Password is required");
                return false;
            }

            return true;
        }
        private void Clear()
        {
            txtuser.Text = string.Empty;
            txtpassword.Text = string.Empty;
            trwMenu.Nodes.Clear();
            MenuPrevilege();
            btncreate.Text = "Create";
            FillListBox();
            clsuserroles.UId =0;
            lstuserlist.ClearSelected();

        }
        private void FillListBox()
        {
            lstuserlist.DataSource = null;
            lstuserlist.SelectedIndexChanged -= lstuserlist_SelectedIndexChanged;
            lstuserlist.Items.Clear();
            DataTable dt = user.GetRecord();
            Dictionary<long,string> list=new Dictionary<long,string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(Convert.ToInt64(dt.Rows[i]["userid"].ToString()), dt.Rows[i]["username"].ToString());
            }
            lstuserlist.DataSource = new BindingSource(list, null);
            lstuserlist.ValueMember = "key";
            lstuserlist.DisplayMember = "Value";
            lstuserlist.SelectedIndexChanged+=new EventHandler(lstuserlist_SelectedIndexChanged);
            lstuserlist.ClearSelected();
        }

        private void lstuserlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstuserlist.SelectedIndex >= 0)
            {
                KeyValuePair<long, string> lst = (KeyValuePair<long, string>)lstuserlist.Items[lstuserlist.SelectedIndex];
                user.userid = lst.Key;
                roles.userid = lst.Key;
                DataTable dt = user.GetSelRecord();
                DataTable dtroles = roles.GetSelRecord();
                if (dt.Rows.Count > 0)
                {
                    txtuser.Text = dt.Rows[0]["username"].ToString();
                    
                    txtpassword.Text = user.Decrypt(dt.Rows[0]["password"].ToString(),"12345!@#$%");
                    trwMenu.Nodes.Clear();
                    MenuPrevilege(dtroles);
                }
                btncreate.Text = "Update";
                clsuserroles.UId = lst.Key;
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            KeyValuePair<long, string> lst = (KeyValuePair<long, string>)lstuserlist.Items[lstuserlist.SelectedIndex];
            user.userid = lst.Key;
            user.Delete();
            roles.userid = lst.Key;
            roles.DelUsrRole();
            Clear();
        }
    }
}
