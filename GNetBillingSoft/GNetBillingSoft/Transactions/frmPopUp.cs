using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Transactions
{
    public partial class frmPopUp : Form
    {
        clsitemdetails items = new clsitemdetails();
        clsperiodinfo period = new clsperiodinfo();
        public string itemid;
        public string desc;
        public bool purchase;
        public frmPopUp()
        {
            InitializeComponent();
           

            DataTable dt = items.SearchItems();
                grdpopup.DataSource = dt;
                grdpopup.Columns[1].Width = 180;            
            lblmsg.Text = "Press Enter to Select Item from Grid";
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "Sales Items  (مبيعات البنود)";
        }

        public frmPopUp(bool pur)
        {
            InitializeComponent();
                DataTable dt = items.SearchProduct();
                grdpopup.DataSource = dt;
                grdpopup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                purchase = pur;

                lblmsg.Text = "Press Enter to Select Item from Grid";
            txtitem.Focus();
        }

        private void grdpopup_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == 13)
            {
                int rowindex = grdpopup.CurrentCell.RowIndex;
            itemid = Convert.ToString(grdpopup.Rows[rowindex].Cells[0].Value);
            desc =Convert.ToString( grdpopup.Rows[rowindex].Cells[1].Value);
            
                this.Close();
            }
            else if (e.KeyData ==(Keys.Control |Keys.S))
            {
                txtitem.Focus();
                lblmsg.Text = "Press F2 for select Items";
            }
        }

        private void txtitem_TextChanged(object sender, EventArgs e)
        {
            if (txtitem.Text != "")
            {
                items.itemid = txtitem.Text;
                items.Description = txtitem.Text;
                 DataTable dt=new DataTable();
                if (purchase)
                {
                    dt = items.SearchProduct();
                    grdpopup.DataSource = dt;
                }
                else
                {
                     dt = items.SearchItems();
                    grdpopup.DataSource = dt;
                }
                if (dt.Rows.Count == 0)
                {
                    lblmsg.Text = "Press Enter to create new item";
                }
            }
        }

        private void txtitem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                
                grdpopup.Focus();
                
                

            }
            else if (e.KeyValue == 13)
            {

                this.items.itemid = txtitem.Text;
                this.items.Description = txtitem.Text;

                
                if (purchase)
                {
                    DataTable dt = items.SearchProduct();
                    
                    if (dt.Rows.Count == 0)
                    {
                        items.itemid = items.GetNextId();
                        this.items.Add();
                        if (items.itemid != "")
                        {
                            period.MaxName = "itemmaxid";
                            if (Convert.ToInt64(period.GetMaxid()) == Convert.ToInt64(items.itemid))
                            {
                                long id = Convert.ToInt64(items.itemid);
                                id++;
                                period.Maxid = id;
                                period.UpdateMaxid();
                            }
                        }
                        dt = items.SearchProduct();
                        grdpopup.DataSource = dt;
                    }
                   // grdpopup.DataSource = dt;
                }
                else
                {
                    DataTable dt = items.SearchItems();
                   
                    if (dt.Rows.Count == 0)
                    {
                        items.itemid = items.GetNextId();
                        this.items.Add();
                        if (items.itemid != "")
                        {
                            period.MaxName = "itemmaxid";
                            if (Convert.ToInt64(period.GetMaxid()) == Convert.ToInt64(items.itemid))
                            {
                                long id = Convert.ToInt64(items.itemid);
                                id++;
                                period.Maxid = id;
                                period.UpdateMaxid();
                            }
                        }
                        dt = items.SearchItems();
                        grdpopup.DataSource = dt;
                    }

                    

                }
               // grdpopup.Focus();
                if (grdpopup.Rows.Count != 0)
                {
                    int rowindex = grdpopup.CurrentCell.RowIndex; 
                    itemid = Convert.ToString(grdpopup.Rows[rowindex].Cells[0].Value);
                    desc = Convert.ToString(grdpopup.Rows[rowindex].Cells[1].Value);
                    this.Close();
                }
                
                
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (grdpopup.Rows.Count == 0)
                    return;
                int curindex = grdpopup.CurrentCell.RowIndex;
                if (curindex == grdpopup.Rows.Count-1)
                    return;
                grdpopup.Rows[curindex].Selected = false;
                
                grdpopup.Rows[curindex + 1].Selected = true;
                grdpopup.CurrentCell = grdpopup.Rows[curindex + 1].Cells[1];
                e.Handled = true;
               

            }
            else if (e.KeyCode == Keys.Up)
            {
                if (grdpopup.Rows.Count == 0)
                    return;
                int upindex = grdpopup.CurrentCell.RowIndex;

                if (upindex == 0)
                    return;
                grdpopup.Rows[upindex].Selected = false;
                grdpopup.CurrentCell = grdpopup.Rows[upindex - 1].Cells[1];
                grdpopup.Rows[upindex - 1].Selected = true;
                e.Handled = true;
            }
           
        }

        private void grdpopup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdpopup_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
               // items.itemid =Convert.ToString(grdpopup.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmpopup_Load(object sender, EventArgs e)
        {

        }
    }
}
