using System;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
using System.Threading;
namespace GNetBillingSoft.Settings
{
    public partial class frmServerSync : Form
    {
        clsServerOperation server = new clsServerOperation();
        delegate void SetLabel(string msg);
        delegate void BtnDelegate(bool f);
        public frmServerSync()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text="سيرفر سينكرنيساتيون";

            this.btnsalesreport.Text = "المبيعاتا لتقارير";
            this.btnSync.Text = "مبيعات البنودا لتقارير";

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ServerSyncData));
            thread.Start();
            SetBtn(false);
          
        }
        void ServerSyncData()
        {
            //server.SyncitemsalesData();
           
            lblmsg.Invoke(new SetLabel(SetText), new object[] { "Sales Item Wise  Synchronize Completed" });
            this.Invoke(new BtnDelegate(SetBtn), new object[] { true });
           
        }

        private void btnsalesreport_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(SalesReportSync));
            thread.Start();
            SetBtn(false);
        }
        void SalesReportSync()
        {
          //  server.SyncSalesReport();
            lblmsg.Invoke(new SetLabel(SetText),new object[]{"Sales Report Synchronize Completed"});
            this.Invoke(new BtnDelegate(SetBtn), new object[] { true });

        }
        void SetText(string msg)
        {
            lblmsg.Text = msg;
        }
        void SetBtn(bool f)
        {
            btnSync.Enabled = f;
            btnsalesreport.Enabled = f;
        }
    }
}
