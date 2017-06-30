using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace GNetBillingSoft.Reports
{
    public partial class frmviewsalesmargin : Form
    {
        public string mode = "";
        public string item = "";
        public DateTime fromdate;
        public DateTime todate;
        public DateTime fromtime;
        public DateTime totime;
        private BindingSource salesmarginreportBindingSource;
        private dsReport dsReport;
        private salesmarginTableAdapter salesmarginTableAdapter;
        private CrystalReportViewer rptsalesmargin;
        public frmviewsalesmargin()
        {
            InitializeComponent();
        }

        private void frmviewsalesmargin_Load(object sender, EventArgs e)
        {
            try
            {
                string dtfrom = fromdate.Year + "-" + fromdate.Month + "-" + fromdate.Day;
                string dtto = todate.Year + "-" + todate.Month + "-" + todate.Day;
                string timefrom = fromtime.TimeOfDay.Hours + ":" + fromtime.TimeOfDay.Minutes;
                string timeto = totime.TimeOfDay.Hours + ":" + totime.TimeOfDay.Minutes;

                DataTable dt=new DataTable();
                if (mode == "Itemwise")
                {
                    salesmarginTableAdapter reportAdapter = new salesmarginTableAdapter();
                    dsReport.salesmarginreportDataTable saletable;
                    if (item == "0")
                        saletable = reportAdapter.GetData(dtfrom, dtto);
                    else
                        saletable = reportAdapter.GetDataBy(item, dtfrom, dtto);
                    dt = (DataTable)saletable;

                    ReportDocument rDoc = new ReportDocument();
                    if (Properties.Settings.Default.Lang == "Arabic")
                        rDoc.Load(Application.StartupPath + "\\CrystalReports\\Arabic\\crySMarginItemAr.rpt");
                    else
                        rDoc.Load(Application.StartupPath + "\\CrystalReports\\crysalesmargin.rpt");

                    rDoc.SetDataSource((DataTable)dt);
                    rDoc.SetParameterValue("fromdate", dtfrom);
                    rDoc.SetParameterValue("todate", dtto);
                    rptsalesmargin.ReportSource = rDoc;
                }
                else if (mode == "daywise")
                {
                    salesmargindaywiseTableAdapter reportdaywise = new salesmargindaywiseTableAdapter();
                    dsReport.salesmargindaywiseDataTable daydt = reportdaywise.GetData(dtfrom, dtto);
                    dt = (DataTable)daydt;
                    //crymargindaywise crydaywise = new crymargindaywise();
                    //crydaywise.SetDataSource(dt);

                    ReportDocument rDoc = new ReportDocument();
                    if (Properties.Settings.Default.Lang == "Arabic")
                        rDoc.Load(Application.StartupPath + "\\CrystalReports\\Arabic\\crySMarginDayAr.rpt");
                    else
                        rDoc.Load(Application.StartupPath + "\\CrystalReports\\crymargindaywise.rpt");
                    rDoc.SetDataSource((DataTable)dt);
                    rDoc.SetParameterValue("fromdate", dtfrom);
                    rDoc.SetParameterValue("todate", dtto);
                    rptsalesmargin.ReportSource = rDoc;
                }
                else if (mode == "invwise")
                {
                    salesmargininvoiceTableAdapter reportinwise = new salesmargininvoiceTableAdapter();
                    dsReport.salesmargininvoiceDataTable invdt = reportinwise.GetData(dtfrom, dtto);
                    dt = (DataTable)invdt;

                    ReportDocument rDoc = new ReportDocument();

                    if (Properties.Settings.Default.Lang == "Arabic")
                        rDoc.Load(Application.StartupPath + "\\CrystalReports\\Arabic\\crySMarginInvAr.rpt");
                    else
                        rDoc.Load(Application.StartupPath + "\\CrystalReports\\crymargininvoice.rpt");
                   
                    rDoc.SetDataSource((DataTable)dt);
                    rDoc.SetParameterValue("fromdate", dtfrom);
                    rDoc.SetParameterValue("todate", dtto);
                    rptsalesmargin.ReportSource = rDoc;
                }
            }
            catch (Exception )
            {

            }

        }
    }
}
