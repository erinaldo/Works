// Type: GNetBillingSoft.rptCashbook
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using CrystalDecisions.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;

namespace GNetBillingSoft.Reports
{
    public partial class rptCashbook : Form
    {
       
        private CrystalReportViewer cryCashBookView;
        public DateTime datefrom;
        public DateTime dateto;

        public rptCashbook()
        {
            InitializeComponent();
        }

       

        private void rptCashbook_Load(object sender, EventArgs e)
        {
           
           

            cashBookTableAdapter data = new cashBookTableAdapter();
            string dtfrom = datefrom.Year + "-" + datefrom.Month + "-" + datefrom.Day;
            string dtto = dateto.Year + "-" + dateto.Month + "-" + dateto.Day;
            dsReport.cashBookDataTable dt = data.GetData(dtfrom, dtto);
            if (Properties.Settings.Default.Lang == "Arabic")
            {
                GNetBillingSoft.ReportsAr.cryCashBookAr cryCashBook = new GNetBillingSoft.ReportsAr.cryCashBookAr();
                cryCashBook.SetDataSource((DataTable)dt);
                cryCashBookView.ReportSource = cryCashBook;
            }
            else
            {
                GNetBillingSoft.ReportsEn.cryCashBookEn cryCashBook = new GNetBillingSoft.ReportsEn.cryCashBookEn();
                cryCashBook.SetDataSource((DataTable)dt);
                this.cryCashBookView.ReportSource = cryCashBook;
            }
        }

       

       

       
    }
}
