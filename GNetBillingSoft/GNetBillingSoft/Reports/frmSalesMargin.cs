using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Reports
{
    public partial class frmSalesMargin : Form
    {
        clsperiodinfo period = new clsperiodinfo();
        clsitemdetails item = new clsitemdetails();
        string mode = "Itemwise";
        public frmSalesMargin()
        {
            InitializeComponent();
            DataTable dt = period.GetRecord();
            dtFrom.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            dtFrom.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            dtTo.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            dtTo.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            dtFrom.Value = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            dtTo.Value = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            DataTable dtitem = item.GetRecord();
            DataRow dr = dtitem.NewRow();
            dr["Description"] = "All";
            dr["itemid"] = 0;
            dtitem.Rows.Add(dr);
            dtitem.DefaultView.Sort = "itemid";
            cmbItem.DataSource = dtitem;
            cmbItem.DisplayMember = "Description";
            cmbItem.ValueMember = "itemid";

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "تقرير الهامش";

            lblFrom.Text = "من";
            lblTo.Text = "الى";

            this.rdItemwise.Text = "البند الحكيم";
            this.rddaywise.Text = "يوم تقرير الحكيم";
            this.rdinvoicewise.Text = "ملخص ارصدة المواد";

            btnshow.Text = "عرض";
            btnclose.Text = "اقفال";
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            frmviewsalesmargin frm = new frmviewsalesmargin();


            frm.mode = this.mode; //(rdItemwise.Checked) ? "Itemwise" : "Daywise";
            frm.item = cmbItem.SelectedValue.ToString();
            frm.fromdate = dtFrom.Value;
            frm.todate = dtTo.Value;
            //frm.fromtime = timefrom.Value;
            //frm.totime = timeto.Value;

            frm.MdiParent = this.MdiParent;
            frm.Show();

        }

        private void frmSalesMargin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsReport.salesmarginreport' table. You can move, or remove it, as needed.
          //  this.salesmarginTableAdapter.Fill(this.dsReport.salesmarginreport);

            
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdItemwise_CheckedChanged(object sender, EventArgs e)
        {
            cmbItem.Enabled = true;
        }
        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            mode = rdo.Tag.ToString();
            if (rdo.Tag == "Itemwise")
            {
                cmbItem.Enabled = true;
            }
            else
            {
                cmbItem.Enabled = false;
            }
        }
        private void rddaywise_CheckedChanged(object sender, EventArgs e)
        {
            cmbItem.Enabled = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
