using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Reports
{
    public partial class frmLedger : Form
    {
        clsgeneralledger ledger = new clsgeneralledger();
        clsperiodinfo period = new clsperiodinfo();
        public frmLedger()
        {
            InitializeComponent();
            cmbparticulars.DataSource = ledger.GetParticulars();
            cmbparticulars.DisplayMember = "particulars";
            cmbparticulars.ValueMember = "particulars";
            DataTable dt = period.GetRecord();
            txtdateFrom.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtdateTo.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());
            txtdateFrom.Value = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            txtdateTo.Value = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }


        private void Arabic()
        {
            this.Text = "(سجل حسابات( دفتر الاستا";

            //Label
            lblFrom.Text = "من";
            lblTo.Text = "الى";

            ////Radio Button
            this.rdAll.Text = "الكل";
            this.rdLedger.Text = "(سجل حسابات(دفتر الاستاذ)";
            

            //Button
            btnShow.Text = "عرض";
            btnclose.Text = "اقفال";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            frmrptLedger frm = new frmrptLedger();
            frm.MdiParent = this.MdiParent;
            frm.dateFrom = DateTime.ParseExact(txtdateFrom.Text, "dd/MM/yyyy", null);
            frm.dateTo = DateTime.ParseExact(txtdateTo.Text, "dd/MM/yyyy", null);
            if (!rdAll.Checked)
            {
                frm.particulars = cmbparticulars.SelectedValue.ToString();
            }
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdAll.Checked)
            {
               
                cmbparticulars.Enabled = false;
            }
            
        }

        private void rdLedger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLedger.Checked)
            {
                cmbparticulars.Enabled = true;
            }
        }
    }
}
