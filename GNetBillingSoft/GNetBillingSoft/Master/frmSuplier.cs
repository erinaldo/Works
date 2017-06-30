using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Master
{
    public partial class frmSuplier : Form
    {
        clssuplierdetails suplier=new clssuplierdetails();
        clsgeneralledger generalledger = new clsgeneralledger();
        public frmSuplier()
        {
            InitializeComponent();
            AddRecord();

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "Supplier (مورد)";

            //Label
            this.lblName.Text = "الاسم";
            this.lblAddr.Text = "عنوان";
            this.lblPhone.Text = "(تليفون (ثابت";
            this.lblOppBal.Text = "الرصيد الافتتاحى";
            
            //Button
            this.btnAdd.Text = "إضافة";
            this.btndel.Text = "الغاء";
            this.btnClose.Text = "اقفال";

            //DataGrid
            this.name.HeaderText = "الاسم";
            this.address.HeaderText = "عنوان";
            this.phoneno.HeaderText = "(تليفون (ثابت";
            this.openingbal.HeaderText = "الرصيد الافتتاحى";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
                if (suplier.GetItems())
                {
                    suplier.Edit();

                }
                else
                {
                    suplier.Add();
                }
                Clear();
            }
        }
        private void Clear()
        {
            AddRecord();
            grdsuplier.ClearSelection();

            txtsupliername.Text = string.Empty;
            txtphoneno.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtopening.Text = string.Empty;

            btnAdd.Text = "Add";


        }
        private void AddRecord()
        {
            grdsuplier.AutoGenerateColumns = false;
            grdsuplier.DataSource = suplier.GetRecord();
        }

        private bool SetData()
        {
            if (Validation())
            {
                if (btnAdd.Text != "Update")
                {
                    suplier.suplierid = suplier.GetNextId();
                }
                suplier.supliername = txtsupliername.Text;
                suplier.address = txtaddress.Text;
                suplier.phonenumber = txtphoneno.Text;
                suplier.openingbalance = Convert.ToDouble(txtopening.Text);

                if (txtopening.Text != "")
                {
                    generalledger.ledcode = generalledger.GetNextId();
                    generalledger.voucherno = suplier.suplierid.ToString();
                    generalledger.ledgerdate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.ledgertime = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    generalledger.particulars = txtsupliername.Text;
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
            if (txtsupliername.Text.Trim() == "")
            {
                errorSuplier.SetError(txtsupliername, "Suplier Name is required");
                return false;

            }
            return true;
        }

        private void grdsuplier_SelectionChanged(object sender, EventArgs e)
        {
            if (grdsuplier.SelectedRows.Count > 0)
            {
                suplier.suplierid = Convert.ToInt64(grdsuplier.Rows[grdsuplier.CurrentCell.RowIndex].Cells[4].Value);
                if (suplier.suplierid != 0)
                {
                    DataTable dt = suplier.GetSelRecord();
                    txtsupliername.Text = dt.Rows[0]["supliername"].ToString();
                    txtaddress.Text = dt.Rows[0]["address"].ToString();
                    txtphoneno.Text = dt.Rows[0]["phonenumber"].ToString();
                    txtopening.Text = dt.Rows[0]["openingbalance"].ToString();
                    btnAdd.Text = "Update";
                }

            }
        }

        private void frmSuplier_Load(object sender, EventArgs e)
        {
            grdsuplier.ClearSelection();
            grdsuplier.SelectionChanged += new EventHandler(grdsuplier_SelectionChanged);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (grdsuplier.SelectedRows.Count > 0)
            {
                suplier.suplierid = Convert.ToInt64(grdsuplier.Rows[grdsuplier.CurrentCell.RowIndex].Cells[4].Value);
                suplier.Delete();
                AddRecord();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
