using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Transactions
{
    public partial class frmTender : Form
    {
        public long  customerid;
        public double total;
        public double paidamount;
        public string remark="";
        clscustomerdetails customer = new clscustomerdetails();
        Control _focused;
        public frmTender()
        {
            InitializeComponent();
            txtnetamount.GotFocus += new EventHandler(txtnetamount_GotFocus);
            txtpaidamount.GotFocus += new EventHandler(txtnetamount_GotFocus);
            txtbalance.GotFocus += new EventHandler(txtnetamount_GotFocus);
        }

        void txtnetamount_GotFocus(object sender, EventArgs e)
        {
            _focused =(TextBox) sender;
        }

        private void frmTender_Load(object sender, EventArgs e)
        {
            if (customerid != 0)
            {
                customer.customerid = customerid;
                DataTable dt = customer.GetSelRecord();
                txtcustomerid.Text = dt.Rows[0]["customerid"].ToString();
                txtcustomername.Text = dt.Rows[0]["customername"].ToString();
                txtnetamount.Text = total.ToString();
                txtpaidamount.Text = paidamount.ToString();
                txtbalance.Text = Convert.ToString(total - paidamount);
                txtpaidamount.Focus();
            }
            else
            {
                this.Close();
            }
             
        }

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            if (txtpaidamount.Text != "")
            {

                double netamt = Convert.ToDouble(txtnetamount.Text);
                double paid = Convert.ToDouble(txtpaidamount.Text);
                txtbalance.Text = Convert.ToString(netamt - paid);
                paidamount = paid;
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void btnsaveonly_Click(object sender, EventArgs e)
        {

        }

        private void btnaction_Click(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)_focused;
            txt.Focus();

            Button btn = (Button)sender;
            SendKeys.Send(btn.Text);
        }

        private void btnremark_Click(object sender, EventArgs e)
        {
            frmRemarks frm = new frmRemarks();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                remark = clsproperties.Remarks;
            }
        }

       
    }
}
