using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
namespace GNetBillingSoft.Transactions
{
    public partial class rptVoucher : Form
    {
        public string voucherno = "";
        public rptVoucher()
        {
            InitializeComponent();
        }

        private void rptvoucher_Load(object sender, EventArgs e)
        {
           /* purchaseinvoiceTableAdapter puradapter = new purchaseinvoiceTableAdapter();
            dsReport.purchaseinvoiceDataTable dPur = new dsReport.purchaseinvoiceDataTable();
            puradapter.FillBy(dPur, this.invioceno);



            rptpurchaseinvoice rpt = new rptpurchaseinvoice();
            rpt.SetDataSource((DataTable)dPur);


            cryPurchase.ReportSource = rpt;*/
            voucherTableAdapter voucherAdapter = new voucherTableAdapter();
            dsReport.voucherDataTable vTable = new dsReport.voucherDataTable();
            voucherAdapter.FillBy(vTable,Convert.ToInt64(this.voucherno));
           
            if (Properties.Settings.Default.Lang == "Arabic")
            {
                GNetBillingSoft.ReportsAr.cryVoucherAr rpt = new GNetBillingSoft.ReportsAr.cryVoucherAr();
                rpt.SetDataSource((DataTable)vTable);
                cryVoucher.ReportSource = rpt;
            }
            else
            {
                GNetBillingSoft.ReportsEn.cryVoucherEn rpt = new GNetBillingSoft.ReportsEn.cryVoucherEn();
                rpt.SetDataSource((DataTable)vTable);
                cryVoucher.ReportSource = rpt;
            }
        }
    }
}
