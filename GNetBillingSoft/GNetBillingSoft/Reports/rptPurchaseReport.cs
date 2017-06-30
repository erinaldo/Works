using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
namespace GNetBillingSoft
{
    public partial class rptPurchaseReport : Form
    {
        public DateTime datefrom;
        public DateTime dateto;
        public rptPurchaseReport()
        {
            InitializeComponent();
        }

        private void rptpurchaseReport_Load(object sender, EventArgs e)
        {
            purchaseReportTableAdapter purAdapter = new purchaseReportTableAdapter();
            string dfrom = datefrom.Year + "-" + datefrom.Month + "-" + datefrom.Day;
            string dto = dateto.Year + "-" + dateto.Month + "-" + dateto.Day;
            dsReport.purchaseReportDataTable dt = purAdapter.GetData(dfrom, dto);

            if (Properties.Settings.Default.Lang == "Arabic")
            {
                GNetBillingSoft.ReportsAr.cryPurReportAr cryReport = new GNetBillingSoft.ReportsAr.cryPurReportAr();
                cryReport.SetDataSource((DataTable)dt);
                cryReport.SetParameterValue("datefrom", datefrom);
                cryReport.SetParameterValue("dateto", dateto);
                rptviewPurReport.ReportSource = cryReport;
            }
            else
            {
                GNetBillingSoft.ReportsEn.cryPurReportEn cryReport = new GNetBillingSoft.ReportsEn.cryPurReportEn();
                cryReport.SetDataSource((DataTable)dt);
                cryReport.SetParameterValue("datefrom", datefrom);
                cryReport.SetParameterValue("dateto", dateto);
                rptviewPurReport.ReportSource = cryReport;
            }
        }
    }
}
