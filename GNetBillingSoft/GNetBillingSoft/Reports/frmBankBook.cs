using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;

namespace GNetBillingSoft.Reports
{
    public partial class frmBankBook : Form
    {
        clsperiodinfo period = new clsperiodinfo();
        public frmBankBook()
        {
            InitializeComponent();
            DataTable dt = period.GetRecord();
            txtfrom.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtto.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());
            txtfrom.Value = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtto.Value = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "النقد في البنك";

            lblfrom.Text = "من";
            lblTo.Text = "الى";

            btnShow.Text = "عرض";
            btnclose.Text = "اقفال";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rptBankbook rpt = new rptBankbook();
            rpt.datefrom = DateTime.ParseExact(txtfrom.Text, "dd/MM/yyyy", null);
            rpt.dateto = DateTime.ParseExact(txtto.Text, "dd/MM/yyyy", null);
            rpt.MdiParent = this.MdiParent;
            rpt.Show();
        }
    }
}
