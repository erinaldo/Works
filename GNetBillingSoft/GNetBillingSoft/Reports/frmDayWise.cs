using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
namespace GNetBillingSoft.Reports
{
    public partial class frmDayWise : Form
    {
        public frmDayWise()
        {
            InitializeComponent();
            txtfrom.Value = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            txtto.Value = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "يوم تقرير الحكيم";

            lblFrom.Text = "من";
            lblTo.Text = "الى";

            btnShow.Text = "عرض";
            btnclose.Text = "اقفال";
        }
		
		
        private void btnShow_Click(object sender, EventArgs e)
        {
            DayWiseTableAdapter daywise = new DayWiseTableAdapter();

            string dtfrom = txtfrom.Value.Year + "-" + txtfrom.Value.Month + "-" + txtfrom.Value.Day;
            string dtto = txtto.Value.Year + "-" + txtto.Value.Month + "-" + txtto.Value.Day;
           
            dsReport.DayWiseDataTable saletable = daywise.GetData(Convert.ToDateTime(dtfrom),Convert.ToDateTime(dtto));
            // crySalesreport cryReport = new crySalesreport();


            // cryReport.SetDataSource((DataTable)saletable);

            //// cryReport.Load(Application.StartupPath+"\\crySalesreport.rpt");
            // cryReport.SetParameterValue("datefrom", datefrom);
            // cryReport.SetParameterValue("todate", dateto);z

            String Path;
            if(Properties.Settings.Default.Lang=="Arabic")
                Path = Application.StartupPath + "\\CrystalReports\\Arabic\\cryDaywiseAr.rpt";
            else
                Path = Application.StartupPath + "\\CrystalReports\\cryDaywise.rpt";
            if (!File.Exists(Path))
            {
                MessageBox.Show("The Directory CrystalReports or Report File cryDaywise.rpt Not Exists");
                return;
            }
            ReportDocument rDoc = new ReportDocument();
            rDoc.Load(Path);
            rDoc.SetDataSource((DataTable)saletable);
            

            cryReportviewer viewer = new cryReportviewer();

            viewer.rDoc = rDoc;
            viewer.MdiParent = this.MdiParent;
            viewer.Show();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
