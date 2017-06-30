using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
namespace GNetBillingSoft.Reports
{
    public partial class rptCashTray : Form
    {
        public DataTable dt = new DataTable();
        public rptCashTray()
        {
            InitializeComponent();
        }

        private void frmcashtrayrpt_Load(object sender, EventArgs e)
        {
            try
            {
                //dsReport.CashTrayDataTable dtcash = (dsReport.CashTrayDataTable)dt;
                String Path;
                if (Properties.Settings.Default.Lang == "Arabic")
                    Path = Application.StartupPath + "\\CrystalReports\\Arabic\\cryCashTrayAr.rpt";
                else
                    Path = Application.StartupPath + "\\CrystalReports\\cryCashTray.rpt";

                if (!File.Exists(Path))
                {
                    MessageBox.Show("The Directory CrystalReports or Report File cryCashTray.rpt Not Exists");
                    return;
                }
                ReportDocument rDoc = new ReportDocument();
                rDoc.Load(Path);
                rDoc.SetDataSource(dt);

                cryCrashReport.ReportSource = rDoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
