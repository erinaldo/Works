using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft
{
    public partial class frmviewsalesreport : Form
    {
        public DateTime datefrom;
        public DateTime dateto;
        public DateTime timefrom;
        public DateTime timeto;
        public frmviewsalesreport()
        {
            InitializeComponent();
        }

        private void frmviewsalesreport_Load(object sender, EventArgs e)
        {
            try
            {
                salesreportTableAdapter reportAdapter = new salesreportTableAdapter();
               
                string dtfrom = datefrom.Year + "-" + datefrom.Month + "-" + datefrom.Day + " " + timefrom.TimeOfDay.Hours + ":" + timefrom.TimeOfDay.Minutes;
                string dtto = dateto.Year + "-" + dateto.Month + "-" + dateto.Day + " " + timeto.TimeOfDay.Hours + ":" + timeto.TimeOfDay.Minutes;
                string fromtime = Convert.ToDateTime(timefrom.TimeOfDay.Hours + ":" + timefrom.TimeOfDay.Minutes).ToString("HH:mm") ;
                string totime =Convert.ToDateTime(timeto.TimeOfDay.Hours + ":" + timeto.TimeOfDay.Minutes).ToString("HH:mm");
                
                dsReport.salesreportDataTable saletable = reportAdapter.GetData(Convert.ToDateTime(dtfrom),Convert.ToDateTime(dtto));
               // crySalesreport cryReport = new crySalesreport();
                

               // cryReport.SetDataSource((DataTable)saletable);
                
               //// cryReport.Load(Application.StartupPath+"\\crySalesreport.rpt");
               // cryReport.SetParameterValue("datefrom", datefrom);
               // cryReport.SetParameterValue("todate", dateto);

                String Path;
                if (Properties.Settings.Default.Lang == "Arabic")
                    Path = Application.StartupPath + "\\CrystalReports\\Arabic\\crySalesReportAr.rpt";
                else
                    Path = Application.StartupPath + "\\CrystalReports\\crySalesreport.rpt";
                
                if (!File.Exists(Path))
                {
                    MessageBox.Show("The Directory CrystalReports or Report File crySalesreport.rpt Not Exists");
                    return;
                }
                ReportDocument rDoc = new ReportDocument();
                rDoc.Load(Path);
                rDoc.SetDataSource((DataTable)saletable);
                rDoc.SetParameterValue("datefrom", datefrom);
                rDoc.SetParameterValue("todate", dateto);
                rDoc.SetParameterValue("fromtime", fromtime);
                rDoc.SetParameterValue("totime", totime);
                rDoc.SetParameterValue("currentuser",clsuserinfo.GetUsername());
                crySalesReport.ReportSource = rDoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
