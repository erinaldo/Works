using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft
{
    public partial class frmSalesReport : Form
    {
        clsperiodinfo period = new clsperiodinfo();
        clstokensettings token = new clstokensettings();
        public frmSalesReport()
        {
            InitializeComponent();
            DataTable dt = period.GetRecord();
            txtfrom.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtfrom.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            txtto.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtto.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            //txtfrom.Value = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            //txtto.Value = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());
            DataTable dtToken = token.GetRecord();
            string from = DateTime.Now.ToString("dd/MM/yyyy");
            string to = DateTime.Now.ToString("dd/MM/yyyy");
            txtfrom.Value = Convert.ToDateTime(from);
            txtto.Value = Convert.ToDateTime(to);
            txtfrom.CustomFormat = "dd/MM/yyyy";
            txtto.CustomFormat = "dd/MM/yyyy";
            timefrom.Value =(dtToken.Rows.Count>0)? Convert.ToDateTime(dtToken.Rows[0]["tokenstarttime"].ToString()):Convert.ToDateTime("12:00 AM");
            timeto.Value =(dtToken.Rows.Count>0)? Convert.ToDateTime(dtToken.Rows[0]["tokenendtime"].ToString()):Convert.ToDateTime("11:59 PM");
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "المبيعاتا لتقارير";

            lblFrom.Text = "من";
            lblTo.Text = "الى";

            btnShow.Text = "عرض";
            btnclose.Text = "اقفال";
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            frmviewsalesreport frm = new frmviewsalesreport();
            frm.MdiParent = this.MdiParent;
            frm.datefrom = DateTime.ParseExact(txtfrom.Text,"dd/MM/yyyy",null);
            frm.dateto = DateTime.ParseExact(txtto.Text,"dd/MM/yyyy",null);
            frm.timefrom = timefrom.Value;
            frm.timeto = timeto.Value;
            frm.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtfrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timefrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeto_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
