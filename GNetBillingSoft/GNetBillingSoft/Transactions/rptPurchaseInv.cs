using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;
namespace GNetBillingSoft.Transactions
{
    public partial class rptPurchaseInv : Form
    {
        public string invioceno = "";
        public rptPurchaseInv()
        {
            InitializeComponent();
        }

        private void rptpurchase_Load(object sender, EventArgs e)
        {
            purchaseinvoiceTableAdapter puradapter = new purchaseinvoiceTableAdapter();
            dsReport.purchaseinvoiceDataTable dPur = new dsReport.purchaseinvoiceDataTable();
            puradapter.FillBy(dPur, this.invioceno);
            if (Properties.Settings.Default.Lang == "Arabic")
            {
                GNetBillingSoft.ReportsAr.cryPurInvoiceAr rpt = new GNetBillingSoft.ReportsAr.cryPurInvoiceAr();
                rpt.SetDataSource((DataTable)dPur);

                cryPurchase.ReportSource = rpt;
            }
            else
            {
                GNetBillingSoft.ReportsEn.cryPurInvoiceEn rpt = new GNetBillingSoft.ReportsEn.cryPurInvoiceEn();
                rpt.SetDataSource((DataTable)dPur);

                cryPurchase.ReportSource = rpt;
            }
        }
    }
}
