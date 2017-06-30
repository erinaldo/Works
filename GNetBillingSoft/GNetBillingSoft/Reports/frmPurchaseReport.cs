using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Reports
{
    public partial class frmPurchaseReport : Form
    {
        clsperiodinfo period = new clsperiodinfo();
        public frmPurchaseReport()
        {
            InitializeComponent();
            DataTable dt = period.GetRecord();
            txtfrom.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtfrom.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            txtto.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtto.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            txtfrom.Value = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtto.Value = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            //this.Text = "";

            lblFrom.Text = "من";
            lblTo.Text = "الى";

            btnShow.Text = "عرض";
            btnclose.Text = "اقفال";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rptPurchaseReport frm = new rptPurchaseReport();
            frm.MdiParent = this.MdiParent;

            frm.datefrom = DateTime.ParseExact(txtfrom.Text, "dd/MM/yyyy",null);
            frm.dateto = DateTime.ParseExact(txtto.Text, "dd/MM/yyyy", null);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
