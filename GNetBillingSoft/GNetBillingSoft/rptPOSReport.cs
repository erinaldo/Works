using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using GNetBillingSoft.DataOperation;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
namespace GNetBillingSoft
{
    public partial class rptPOSReport : Form
    {
        public long posinvoice;
        public string particulars;
        clsgeneralledger general = new clsgeneralledger();
        Font printFont;
        StreamReader streamToPrint;
        public rptPOSReport()
        {
            InitializeComponent();
        }

        private void frmposreport_Load(object sender, EventArgs e)
        {
            try
            {
                 string path = Application.StartupPath + "\\CrystalReports\\cryPosreport.rpt";
                 if (!File.Exists(path))
                 {
                     MessageBox.Show("The Directory CrystalReports or Report File cryPosreport.rpt Not Exists");
                     return;
                 }
                posTableAdapter pos = new posTableAdapter();
                dsReport.PosInvoiceDataTable dt = pos.GetData(posinvoice);
                salesinvoiceTableAdapter saladapter = new salesinvoiceTableAdapter();
                dsReport.salesinvoiceDataTable satd = saladapter.GetData(Convert.ToString(posinvoice));

                general.particulars = particulars;
                general.voucherno = Convert.ToString(posinvoice);
                double oldbalance = Convert.ToDouble(general.OldBalance());

                //cryPosreport cryReport = new cryPosreport();
                //cryReport.SetDataSource((DataTable)dt);

                //cryPOSView.ReportSource = cryReport;
                ReportDocument rDoc = new ReportDocument();
                rDoc.Load(Application.StartupPath + "\\CrystalReports\\cryPosreport.rpt");
                rDoc.SetDataSource((DataTable)satd);
                
                ParameterFields paramfields = new ParameterFields();
                ParameterField parameter = new ParameterField();
                ParameterDiscreteValue discretedvalue = new ParameterDiscreteValue();
                parameter.Name = "oldbalance";
               
                discretedvalue.Value = oldbalance;
                parameter.CurrentValues.Add(discretedvalue);
                paramfields.Add(parameter);
               
               //cryPOSView.ParameterFieldInfo = paramfields;

               //cryPOSView.ReportSource = rDoc;
                rDoc.SetParameterValue("oldbalance", oldbalance);
               rDoc.PrintToPrinter(1, true, 1, 1);
               this.Close();
                   
                    
                
                
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
        public void Printing()
        {
            posTableAdapter pos = new posTableAdapter();
            dsReport.PosInvoiceDataTable dt = pos.GetData(posinvoice);
            salesinvoiceTableAdapter saladapter = new salesinvoiceTableAdapter();
            dsReport.salesinvoiceDataTable satd = saladapter.GetData(Convert.ToString(posinvoice));

            general.particulars = particulars;
            general.voucherno = Convert.ToString(posinvoice);
            double oldbalance = Convert.ToDouble(general.OldBalance());

            clsprintersettings printing = new clsprintersettings();
            printing.PrintHeader();
           // printing.PrintDetails(posinvoice.ToString(), (DataTable)satd,oldbalance);
            printing.Close();
            streamToPrint = new StreamReader(Application.StartupPath + "\\test.txt");

            try
            {
                printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                    this.Close();
            }
            finally
            {
                streamToPrint.Close();
            }


        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file. 
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page. 
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }
}
