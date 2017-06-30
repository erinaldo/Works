using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
namespace GNetBillingSoft.Reports
{
    public partial class frmrptLedger : Form
    {
        public DateTime dateFrom;
        public DateTime dateTo;
        public string particulars = "";

        public frmrptLedger()
        {
            InitializeComponent();
        }

        private void frmrptLedger_Load(object sender, EventArgs e)
        {
            generalledgerTableAdapter ledgeradp = new generalledgerTableAdapter();
            dsReport.generalledgerDataTable dt;
            string dfrom = dateFrom.Year + "-" + dateFrom.Month + "-" + dateFrom.Day;
            string dto = dateTo.Year + "-" + dateTo.Month + "-" + dateTo.Day;
            if (particulars != "")
                dt = ledgeradp.GetData(particulars, dfrom, dto);
            else
                dt = ledgeradp.GetDataBy(dfrom, dto);

            if (Properties.Settings.Default.Lang == "Arabic")
            {
                GNetBillingSoft.ReportsAr.cryLedgerAr cryReport = new GNetBillingSoft.ReportsAr.cryLedgerAr();
                cryReport.SetDataSource((DataTable)dt);
                rptLedger.ReportSource = cryReport;
            }
            else
            {
                GNetBillingSoft.ReportsEn.cryLedgerEn cryReport = new GNetBillingSoft.ReportsEn.cryLedgerEn();
                cryReport.SetDataSource((DataTable)dt);
                //cryReport.SetParameterValue("fromdate", dateFrom);
                //cryReport.SetParameterValue("todate", dateTo);
                //cryReport.SetParameterValue("particulars", particulars);
                rptLedger.ReportSource = cryReport;
            }           
           
        }
    }
}
