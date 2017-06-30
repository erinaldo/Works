using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace GNetBillingSoft
{
    public partial class cryReportviewer : Form
    {
        public ReportDocument rDoc=new ReportDocument();
        public string filename;
        public cryReportviewer()
        {
            InitializeComponent();

        }

        private void cryviewer_Load(object sender, EventArgs e)
        {
           

            //rptreceipt rpt = new rptreceipt();

            //rpt.SetDataSource((DataTable)satd);

            cryviewer.ReportSource = rDoc; 
        }
        
    }
}
