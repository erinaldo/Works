using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
namespace GNetBillingSoft.Reports
{
    public partial class rptBankbook : Form
    {
        public DateTime datefrom;
        public DateTime dateto;
        public rptBankbook()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            bankBookTableAdapter badapter = new bankBookTableAdapter();
            string dtfrom = datefrom.Year + "-" + datefrom.Month + "-" + datefrom.Day;
            string dtto = dateto.Year + "-" + dateto.Month + "-" + dateto.Day;
            dsReport.bankBookDataTable dt = badapter.GetData(dtfrom, dtto);

            if (Properties.Settings.Default.Lang == "Arabic")
            {
                GNetBillingSoft.ReportsAr.cryBankbookAr cryst = new GNetBillingSoft.ReportsAr.cryBankbookAr();
                cryst.SetDataSource((DataTable)dt);
                cryBankView.ReportSource = cryst;
            }
            else
            {
                GNetBillingSoft.ReportsEn.cryBankbookEn cryst = new GNetBillingSoft.ReportsEn.cryBankbookEn();
                cryst.SetDataSource((DataTable)dt);
                cryBankView.ReportSource = cryst;
            }
        }
    }
}
