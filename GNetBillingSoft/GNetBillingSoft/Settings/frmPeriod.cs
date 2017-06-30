using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Settings
{
    public partial class frmPeriod : Form
    {
        clsperiodinfo period = new clsperiodinfo();
     
        public frmPeriod()
        {
            InitializeComponent();
           // txtPeriodFrom.MinDate = period.periodstart;
           // txtPeriodFrom.MaxDate = period.periodend;
            DataTable dt = period.GetRecord();
            txtPeriodFrom.Value = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());


           // txtPeriodTo.MinDate = period.periodstart;
          //  txtper
            txtPeriodTo.Value = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "إعداد الفترة";

            groupBox1.Text = "إعداد الفترة";

            lblFrom.Text = "من";
            lblTo.Text = "الى";
            btnSave.Text = "حفظ";
            btnClose.Text = "اقفال";

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            period.periodstart = txtPeriodFrom.Value;
            period.periodend = txtPeriodTo.Value;
            period.EditPeriod();
            mainmdi main = new mainmdi();
            main.SetCompanyInfo();
            
            main.statusStrip1.Refresh();
            main.Refresh();
            this.Close();
        }
    }
}
