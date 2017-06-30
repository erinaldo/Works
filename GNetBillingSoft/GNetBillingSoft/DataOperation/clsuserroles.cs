using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace GNetBillingSoft.DataOperation
{


    public class clsuserroles
    {
        //int mnuCount = 1;
        private const string mvartablename = "userroles";

        private long mvaruserroleid;

        private long mvaruserid;

        private string mvarmenuname;
        private static long mvarstaticuserid;
        public long userroleid
        {
            get
            {
                return this.mvaruserroleid;
            }
            set
            {
                this.mvaruserroleid = value;
            }
        }

        public long userid
        {
            get
            {
                return this.mvaruserid;
            }
            set
            {
                this.mvaruserid = value;
            }
        }

        public string menuname
        {
            get
            {
                return this.mvarmenuname;
            }
            set
            {
                this.mvarmenuname = value;
            }
        }
        public static long UId
        {
            get
            {
                return mvarstaticuserid;
            }
            set
            {
                mvarstaticuserid = value;
            }
        }

        public void Add()
        {
            string strsql;
            strsql = "INSERT INTO " + mvartablename + "([userroleid],[userid],[menuname]) VALUES  ('" + mvaruserroleid + "','" + mvaruserid + "','" + mvarmenuname + "')";
            dboperation.ExecuteSql(strsql);
        }

        public void Edit()
        {
            string strsql;
            strsql = "update " + mvartablename + " set userid='" + mvaruserid + "',menuname='" + mvarmenuname + "' where   userroleid = " + mvaruserroleid + "";
            dboperation.ExecuteSql(strsql);
        }

        public void Delete()
        {
            string strsql;
            strsql = "Delete from " + mvartablename + " where   userroleid = " + mvaruserroleid + " ";
            dboperation.ExecuteSql(strsql);
        }
        public void DeleteRole()
        {
            string strsql;
            strsql = "Delete from " + mvartablename + " where   userid = " + mvaruserid + " and menuname='" + mvarmenuname + "' ";
            dboperation.ExecuteSql(strsql);
        }
        public void DelUsrRole()
        {
            string strsql;
            strsql = "Delete from " + mvartablename + " where   userid = " + mvaruserid;
            dboperation.ExecuteSql(strsql);
        }
        public int GetNextId()
        {
            string strsql;
            strsql = "select max(userroleid) from " + mvartablename + "";
            object obj = dboperation.GetAValue(strsql);
            if ((obj == DBNull.Value))
            {
                return 1;
            }
            else
            {
                return (Convert.ToInt32(obj) + 1);
            }
        }

        public DataTable GetRecord()
        {
            string strsql;
            strsql = "select userroleid,userid,menuname from " + mvartablename + " ";
            return dboperation.GetDataTable(strsql);
        }
        public DataTable GetSelRecord()
        {
            string strsql;
            strsql = "select userroleid,userid,menuname from " + mvartablename + " where userid=" + mvaruserid + " ";
            return dboperation.GetDataTable(strsql);
        }
        public bool GetItems()
        {
            string strsql;
            bool result = false;
            strsql = "select * from " + mvartablename + " where userroleid=" + mvaruserroleid + " ";
            DataTable dt = dboperation.GetDataTable(strsql);
            if ((dt.Rows.Count > 0))
            {
                result = true;
                // Add Your Variable Here
            }
            return result;
        }
        private DataTable GetUserRoles(long userid, string menuname)
        {
            string strsql = "select * from " + mvartablename + " where userid=" + userid + " and menuname='" + menuname + "'";
            return dboperation.GetDataTable(strsql);
        }
        public void SetMenus(long userid, MenuStrip mnu = null, ToolStripMenuItem stripmnu = null)
        {

            if (mnu != null)
            {
                foreach (ToolStripMenuItem item in mnu.Items)
                {
                    DataTable dt = GetUserRoles(userid, item.Name);
                    if (dt.Rows.Count == 0)
                    {
                        item.Visible = false;
                    }
                    if (item.DropDownItems.Count > 0)
                    {
                        SetMenus(userid,  null, item);
                    }
                }
            }
            else if (stripmnu != null)
            {
                foreach (ToolStripMenuItem item in stripmnu.DropDownItems)
                {
                    DataTable dt = GetUserRoles(userid, item.Name);
                    if (dt.Rows.Count == 0)
                    {
                        item.Visible = false;

                    }
                    if (item.DropDownItems.Count > 0)
                    {
                        SetMenus(userid,  null, item);
                    }
                }
            }

        }
        public void AddSideMenu(FlowLayoutPanel panel,EventHandler eventHandler, MenuStrip mnu = null, ToolStripMenuItem stripmenu = null,long userid=0)
        {
            if (mnu != null)
            {
                DataTable dt=null;
                foreach (ToolStripMenuItem item in mnu.Items)
                {
                    if (item.Name == "mnuTransactions")
                    {                      
                        Label lbl = new Label();
                        lbl.Text = (Properties.Settings.Default.Lang == "Arabic") ? "المعاملات" : " TRANSACTIONS";
                        lbl.Font = new Font(lbl.Font.FontFamily, 14);
                        lbl.Width = panel.Width;
                        lbl.Height = 25;
                        lbl.ForeColor = Color.Red;
                        lbl.BorderStyle = BorderStyle.Fixed3D;
                        lbl.BackColor = Color.DarkGray;
                        if (userid != 0)
                        {
                            dt = GetUserRoles(userid, item.Name);
                           
                            if (dt.Rows.Count > 0)
                            {
                                panel.Controls.Add(lbl);
                                AddSideMenu(panel, eventHandler, null, item,userid);
                            }
                        }
                        else
                        {

                            panel.Controls.Add(lbl);
                            AddSideMenu(panel, eventHandler, null, item,userid);
                        }
                        
                    }
                    else if (item.Name == "mnuMaster")
                    {
                        Label lbl = new Label();
                        lbl.Text = (Properties.Settings.Default.Lang == "Arabic") ? "بيانات الاساسية" : " MASTERS";
                        lbl.Font = new Font(lbl.Font.FontFamily, 14);
                        lbl.Width = panel.Width;
                        lbl.Height = 25;
                        lbl.ForeColor = Color.Red;
                        lbl.BorderStyle = BorderStyle.Fixed3D;
                        lbl.BackColor = Color.DarkGray;
                        if (userid != 0)
                        {
                            dt = GetUserRoles(userid, item.Name);

                            if (dt.Rows.Count > 0)
                            {
                                panel.Controls.Add(lbl);
                                AddSideMenu(panel, eventHandler, null, item,userid);
                            }
                        }
                        else
                        {
                            panel.Controls.Add(lbl);
                            AddSideMenu(panel, eventHandler, null, item,userid);
                        }
                    }
                    else if (item.Name == "mnuReports")
                    {
                        Label lbl = new Label();
                        lbl.Text = (Properties.Settings.Default.Lang == "Arabic") ? "التقارير" : " REPORTS";
                        lbl.Font = new Font(lbl.Font.FontFamily, 14);
                        lbl.Width = panel.Width;
                        lbl.Height = 25;
                        lbl.ForeColor = Color.Red;
                        lbl.BorderStyle = BorderStyle.Fixed3D;
                        lbl.BackColor = Color.DarkGray;
                        if (userid != 0)
                        {
                            dt = GetUserRoles(userid, item.Name);

                            if (dt.Rows.Count > 0)
                            {
                                panel.Controls.Add(lbl);
                                AddSideMenu(panel, eventHandler, null, item,userid);
                            }
                        }
                        else
                        {
                            panel.Controls.Add(lbl);
                            AddSideMenu(panel, eventHandler, null, item,userid);
                        }
                    }
                    else if (item.Name == "mnuSettings")
                    {
                        Label lbl = new Label();
                        lbl.Text = (Properties.Settings.Default.Lang == "Arabic") ? "SETTINGS" : "SETTINGS";
                        lbl.Font = new Font(lbl.Font.FontFamily, 14);
                        lbl.Width = panel.Width;
                        lbl.Height = 25;
                        lbl.ForeColor = Color.Red;
                        lbl.BorderStyle = BorderStyle.Fixed3D;
                        lbl.BackColor = Color.DarkGray;
                        if (userid != 0)
                        {
                            dt = GetUserRoles(userid, item.Name);

                            if (dt.Rows.Count > 0)
                            {
                                panel.Controls.Add(lbl);
                                AddSideMenu(panel, eventHandler, null, item, userid);
                            }
                        }
                        else
                        {
                            panel.Controls.Add(lbl);
                            AddSideMenu(panel, eventHandler, null, item, userid);
                        }
                    }
                }
            }
            else if (stripmenu != null)
            {
                DataTable dt = null;
                foreach (ToolStripMenuItem strip in stripmenu.DropDownItems)
                {
                    if (strip.DropDownItems.Count > 0)
                    {
                        foreach (ToolStripMenuItem strsub in strip.DropDownItems)
                        {
                            var rc = GNetBillingSoft.Properties.Resources.ResourceManager.GetObject(strsub.Name);

                            Button btn = new Button();
                            btn.Text = strsub.Text;
                            
                            btn.Image = (System.Drawing.Image)rc;
                            btn.TextAlign = ContentAlignment.BottomCenter;
                            btn.Name = strsub.Name;
                            btn.Click += eventHandler;
                            btn.Margin = new Padding(1);
                            //  btn.Click += new EventHandler(strsub.PerformClick);
                            btn.Width = 115;
                            btn.Height = 77;
                           
                            if (userid != 0)
                            {
                                dt = GetUserRoles(userid, strsub.Name);

                                if (dt.Rows.Count > 0)
                                {
                                   // mnuCount++;
                                    panel.Controls.Add(btn);
                                }
                            }
                            else
                            {
                                //mnuCount++;
                                panel.Controls.Add(btn);
                            }
                        }
                    }
                    else
                    {
                        var rc = GNetBillingSoft.Properties.Resources.ResourceManager.GetObject(strip.Name);
                        Button btn = new Button();
                        btn.Image = (System.Drawing.Image)rc;
                        btn.Text = strip.Text;
                        btn.Name = strip.Name;
                        btn.Margin = new Padding(1);
                        btn.TextAlign = ContentAlignment.BottomCenter;
                        btn.Click += (eventHandler);

                        btn.Width = 115;
                        btn.Height = 77;
                        if (userid != 0)
                        {
                            dt = GetUserRoles(userid, strip.Name);

                            if (dt.Rows.Count > 0)
                            {
                                //mnuCount++;
                                panel.Controls.Add(btn);
                            }
                        }
                        else
                        {
                            //mnuCount++;
                            panel.Controls.Add(btn);
                        }
                    }
                }
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Master.frmItemMaster frm = new Master.frmItemMaster();
            frm.MdiParent = new mainmdi();
            frm.Show();
        }
    }
}
