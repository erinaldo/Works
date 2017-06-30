using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
using CrystalDecisions.CrystalReports.Engine;
namespace GNetBillingSoft.Reports
{
    public partial class rptItemSales : Form
    {
        public DateTime from;
        public DateTime to;
        public DateTime timefrom;
        public DateTime timeto;
        public long group;
        public long item;
        public rptItemSales()
        {
            InitializeComponent();
        }

        private void rptitemsales_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                itemsalesTableAdapter reportAdapter = new itemsalesTableAdapter();
                dsReport.itemsalesDataTable itemsales=new dsReport.itemsalesDataTable();
                string fromdate = from.Year + "-" + from.Month + "-" + from.Day + " " + timefrom.Hour + ":" + timefrom.Minute;
                string todate = to.Year + "-" + to.Month + "-" + to.Day + " " + timeto.Hour + ":" + timeto.Minute;
                if (group == 0 && item == 0)
                {
                    itemsales = reportAdapter.GetData(Convert.ToDateTime(fromdate),Convert.ToDateTime(todate));
                }
                else if (group >0 && item == 0)
                {
                    itemsales = reportAdapter.GetheadDataBy(Convert.ToDateTime(fromdate), Convert.ToDateTime(todate), group);
                }
                else if(group==0 && item>0)
                {
                    itemsales = reportAdapter.GetItemDataBy(Convert.ToDateTime(fromdate), Convert.ToDateTime(todate), item.ToString());
                }
                else if (group > 0 && item > 0)
                {
                    itemsales = reportAdapter.GetBothDataBy(Convert.ToDateTime(fromdate), Convert.ToDateTime(todate), group, item.ToString());
                }

                dt = (DataTable)itemsales;

                //crysalesmargin cryReport = new crysalesmargin();
                ReportDocument rDoc = new ReportDocument();
                if (Properties.Settings.Default.Lang == "Arabic")
                    rDoc.Load(Application.StartupPath + "\\CrystalReports\\Arabic\\cryItemSalesAr.rpt");
                else
                    rDoc.Load(Application.StartupPath + "\\CrystalReports\\cryitemsales.rpt");

                rDoc.SetDataSource((DataTable)dt);
                rDoc.SetParameterValue("fromdate", fromdate);
                rDoc.SetParameterValue("todate", todate);
                // cryReport.SetDataSource(dt);

                // cryReport.SetParameterValue("fromdate",dtfrom);
                //  cryReport.SetParameterValue("todate", dtto);
                //rptsalesmargin.ReportSource = cryReport;
                cryItemSalesView.ReportSource = rDoc;
                

            }
            catch (Exception )
            {

            }
        }
    }
}
