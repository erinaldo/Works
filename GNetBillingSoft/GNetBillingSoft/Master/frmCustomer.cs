using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Master
{
    public partial class frmCustomer : Form
    {
        clscustomerdetails cust = new clscustomerdetails();
        clsgeneralledger generalledger = new clsgeneralledger();
        public frmCustomer()
        {
            InitializeComponent();
            AddRecord();

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }
        private void Arabic()
        {
            this.Text = "Customer (عميل)";

            //Label
            this.lblName.Text = "الاسم";
            this.lblAddr.Text = "عنوان";
            this.lblPhone.Text = "(تليفون (ثابت";
            this.lblOppBal.Text = "الرصيد الافتتاحى";

            //Button
            this.btnAdd.Text = "إضافة";
            this.btnDel.Text = "الغاء";

            //DataGrid
            this.name.HeaderText = "الاسم";
            this.address.HeaderText = "عنوان";
            this.phoneno.HeaderText = "(تليفون (ثابت";
            this.openingbal.HeaderText = "الرصيد الافتتاحى";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
                if (cust.GetItems())
                {
                    cust.Edit();

                }
                else
                {
                    cust.Add();
                }
                Clear();
            }
        }
        private bool SetData()
        {
            if (Validation())
            {
                if (btnAdd.Text != "Update")
                {
                    cust.customerid = cust.GetNextId();
                }
                cust.customername = txtcustomername.Text;
                cust.address = txtaddress.Text;
                cust.phonenumber = txtphoneno.Text;
                cust.CusOpening = Convert.ToDouble(txtopening.Text);

                if (txtopening.Text != "")
                {
                    generalledger.ledcode = generalledger.GetNextId();
                    generalledger.voucherno = cust.customerid.ToString();
                    generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.particulars = txtcustomername.Text;
                    if (Convert.ToInt64(txtopening.Text) < 0)
                    {
                        generalledger.Debitamt = 0;
                        generalledger.Creditamt = Convert.ToDouble(txtopening.Text);
                    }
                    else
                    {
                        generalledger.Debitamt = Convert.ToDouble(txtopening.Text);
                        generalledger.Creditamt = 0;
                    }


                    generalledger.Balance = 0;
                    generalledger.VType = "OP";

                    generalledger.DeleteLedger();
                    generalledger.Add();
                }
                return true;
            }
            return false;
        }
        private bool Validation()
        {
            if (txtcustomername.Text.Trim() == "")
            {
                errorCustomer.SetError(txtcustomername, "Customer name is required");
                return false;

            }
            return true;
        }
        private void Clear()
        {
            AddRecord();
            grdcustomer.ClearSelection();

            txtcustomername.Text = string.Empty;
            txtphoneno.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtopening.Text = string.Empty;

            btnAdd.Text = "Add";


        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {


            grdcustomer.ClearSelection();
            grdcustomer.SelectionChanged += new EventHandler(dgvcustomer_SelectionChanged);
        }

        void dgvcustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (grdcustomer.SelectedRows.Count > 0)
            {
                cust.customerid = Convert.ToInt64(grdcustomer.Rows[grdcustomer.CurrentCell.RowIndex].Cells[4].Value);
                DataTable dt = cust.GetSelRecord();
                txtcustomername.Text = dt.Rows[0]["customername"].ToString();
                txtaddress.Text = dt.Rows[0]["address"].ToString();
                txtphoneno.Text = dt.Rows[0]["phonenumber"].ToString();
                txtopening.Text = dt.Rows[0]["cusopening"].ToString();
                btnAdd.Text = "Update";

            }
        }
        private void AddRecord()
        {
            grdcustomer.AutoGenerateColumns = false;
            grdcustomer.DataSource = cust.GetRecord();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (grdcustomer.SelectedRows.Count > 0)
            {
                cust.customerid = Convert.ToInt64(grdcustomer.Rows[grdcustomer.CurrentCell.RowIndex].Cells[4].Value);
                cust.Delete();
                AddRecord();
            }
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (e.KeyChar == '\r')
                    if (this.ActiveControl != null)
                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }
    }
}
