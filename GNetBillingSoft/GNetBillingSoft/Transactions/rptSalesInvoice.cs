using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using GNetBillingSoft.DataOperation;
using GNetBillingSoft.dsReportTableAdapters;
namespace GNetBillingSoft.Transactions
{
    public partial class rptSalesInvoice : Form
    {
        clssalesinvoice sales = new clssalesinvoice();
        clssalesdetails salesdetails = new clssalesdetails();
        public string invoice = "";
        public rptSalesInvoice()
        {
            InitializeComponent();
           
        }

        private void frmreceipt_Load(object sender, EventArgs e)
        {
            try
            {
                salesinvoiceTableAdapter saladapter = new salesinvoiceTableAdapter();
                dsReport.salesinvoiceDataTable satd = saladapter.GetData(this.invoice);
                ReportDocument rDoc = new ReportDocument();
                rDoc.Load(Application.StartupPath + "\\CrystalReports\\rptreceipt.rpt");
                rDoc.SetDataSource((DataTable)satd);

                //rptreceipt rpt = new rptreceipt();

                //rpt.SetDataSource((DataTable)satd);

                cryReceipt.ReportSource = rDoc; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }
    }
}
