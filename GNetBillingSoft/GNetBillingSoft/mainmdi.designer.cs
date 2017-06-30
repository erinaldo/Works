// Type: GNetBillingSoft.mainmdi
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using GNetBillingSoft.DataOperation;
using GNetBillingSoft.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GNetBillingSoft
{
    partial  class mainmdi
    {
        private IContainer components = (IContainer)null;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuNewCompany;
        private ToolStripMenuItem mnuOpenCompany;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuTransactions;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem mnuSalesInvoice;
        private ToolStripMenuItem mnuSalesReturn;
        private ToolStripMenuItem purchaseToolStripMenuItem;
        private ToolStripMenuItem mnuPurchaseInvoice;
        private ToolStripMenuItem mnuPurchaseReturn;
        private ToolStripMenuItem mnuVoucher;
        private ToolStripMenuItem mnuReports;
        private ToolStripMenuItem mnuSalesReport;
        private ToolStripMenuItem mnuPurchaseReport;
        private ToolStripMenuItem mnuStock;
        private ToolStripMenuItem mnuCashBook;
        private ToolStripMenuItem mnuBankBook;
        private ToolStripMenuItem mnuMaster;
        private ToolStripMenuItem mnuitems;
        private ToolStripMenuItem mnuHelp;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem mnusalesrpt;
        private ToolStripMenuItem mnusalesmargin;
        private ToolStripMenuItem mnuSettings;
        private ToolStripMenuItem mnuPeriod;
        public ToolStripStatusLabel stripcompany;
        public ToolStripStatusLabel stripperiod;
        public StatusStrip statusStrip1;

        

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmdi));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenRmtCmp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnulogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTransactions = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalesInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalesReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPOS = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchaseInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchaseReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVoucher = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitems = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnit_Remark = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomerMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalesReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusalesrpt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusalesmargin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuitemsalesreport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDaywise = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchaseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLedger = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCashBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBankBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCashTray = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalesCash = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeriod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTokenSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSynchronize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArabic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripcompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripperiod = new System.Windows.Forms.ToolStripStatusLabel();
            this.sidebarmenu = new System.Windows.Forms.Panel();
            this.flowTransaction = new System.Windows.Forms.FlowLayoutPanel();
            this.btnhide = new System.Windows.Forms.Button();
            this.synchronizedata = new System.ComponentModel.BackgroundWorker();
            this.synchronizeitemwise = new System.ComponentModel.BackgroundWorker();
            this.mnuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.sidebarmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.Teal;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTransactions,
            this.mnuMaster,
            this.mnuReports,
            this.mnuSettings,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(751, 25);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewCompany,
            this.mnuOpenCompany,
            this.mnuOpenRmtCmp,
            this.mnulogout,
            this.mnuExit});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuFile.ForeColor = System.Drawing.Color.Black;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(42, 21);
            this.mnuFile.Tag = "1";
            this.mnuFile.Text = "File";
            // 
            // mnuNewCompany
            // 
            this.mnuNewCompany.Name = "mnuNewCompany";
            this.mnuNewCompany.Size = new System.Drawing.Size(222, 22);
            this.mnuNewCompany.Tag = "2";
            this.mnuNewCompany.Text = "New Company";
            this.mnuNewCompany.Click += new System.EventHandler(this.mnuNewCompany_Click);
            // 
            // mnuOpenCompany
            // 
            this.mnuOpenCompany.Name = "mnuOpenCompany";
            this.mnuOpenCompany.Size = new System.Drawing.Size(222, 22);
            this.mnuOpenCompany.Tag = "3";
            this.mnuOpenCompany.Text = "Open Company";
            this.mnuOpenCompany.Click += new System.EventHandler(this.mnuOpenCompany_Click);
            // 
            // mnuOpenRmtCmp
            // 
            this.mnuOpenRmtCmp.Name = "mnuOpenRmtCmp";
            this.mnuOpenRmtCmp.Size = new System.Drawing.Size(222, 22);
            this.mnuOpenRmtCmp.Text = "Open Remote Company";
            this.mnuOpenRmtCmp.Click += new System.EventHandler(this.mnuOpenRmtCmp_Click);
            // 
            // mnulogout
            // 
            this.mnulogout.Name = "mnulogout";
            this.mnulogout.Size = new System.Drawing.Size(222, 22);
            this.mnulogout.Text = "Log Out";
            this.mnulogout.Click += new System.EventHandler(this.mnulogout_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(222, 22);
            this.mnuExit.Tag = "4";
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuTransactions
            // 
            this.mnuTransactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.purchaseToolStripMenuItem,
            this.mnuVoucher});
            this.mnuTransactions.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuTransactions.ForeColor = System.Drawing.Color.Black;
            this.mnuTransactions.Name = "mnuTransactions";
            this.mnuTransactions.Size = new System.Drawing.Size(98, 21);
            this.mnuTransactions.Text = "Transactions";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalesInvoice,
            this.mnuSalesReturn,
            this.mnuPOS});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // mnuSalesInvoice
            // 
            this.mnuSalesInvoice.Name = "mnuSalesInvoice";
            this.mnuSalesInvoice.Size = new System.Drawing.Size(152, 22);
            this.mnuSalesInvoice.Text = "Sales";
            this.mnuSalesInvoice.Click += new System.EventHandler(this.mnuSalesInvoice_Click);
            // 
            // mnuSalesReturn
            // 
            this.mnuSalesReturn.Name = "mnuSalesReturn";
            this.mnuSalesReturn.Size = new System.Drawing.Size(152, 22);
            this.mnuSalesReturn.Text = "Return Sales";
            this.mnuSalesReturn.Click += new System.EventHandler(this.mnuSalesReturn_Click);
            // 
            // mnuPOS
            // 
            this.mnuPOS.Name = "mnuPOS";
            this.mnuPOS.Size = new System.Drawing.Size(152, 22);
            this.mnuPOS.Text = "POS";
            this.mnuPOS.Click += new System.EventHandler(this.mnuPOS_Click);
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPurchaseInvoice,
            this.mnuPurchaseReturn});
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // mnuPurchaseInvoice
            // 
            this.mnuPurchaseInvoice.Name = "mnuPurchaseInvoice";
            this.mnuPurchaseInvoice.Size = new System.Drawing.Size(155, 22);
            this.mnuPurchaseInvoice.Text = "Purchase";
            this.mnuPurchaseInvoice.Click += new System.EventHandler(this.mnuPurchaseInvoice_Click);
            // 
            // mnuPurchaseReturn
            // 
            this.mnuPurchaseReturn.Name = "mnuPurchaseReturn";
            this.mnuPurchaseReturn.Size = new System.Drawing.Size(155, 22);
            this.mnuPurchaseReturn.Text = "Purchase Ret";
            this.mnuPurchaseReturn.Click += new System.EventHandler(this.mnuPurchaseReturn_Click);
            // 
            // mnuVoucher
            // 
            this.mnuVoucher.Name = "mnuVoucher";
            this.mnuVoucher.Size = new System.Drawing.Size(152, 22);
            this.mnuVoucher.Text = "Voucher";
            this.mnuVoucher.Click += new System.EventHandler(this.mnuVoucher_Click);
            // 
            // mnuMaster
            // 
            this.mnuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuitems,
            this.mnuUnit_Remark,
            this.mnuCustomerMaster,
            this.mnuSupplier});
            this.mnuMaster.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuMaster.ForeColor = System.Drawing.Color.Black;
            this.mnuMaster.Name = "mnuMaster";
            this.mnuMaster.Size = new System.Drawing.Size(62, 21);
            this.mnuMaster.Tag = "5";
            this.mnuMaster.Text = "Master";
            // 
            // mnuitems
            // 
            this.mnuitems.Name = "mnuitems";
            this.mnuitems.Size = new System.Drawing.Size(154, 22);
            this.mnuitems.Tag = "6";
            this.mnuitems.Text = "Items";
            this.mnuitems.Click += new System.EventHandler(this.mnuitems_Click);
            // 
            // mnuUnit_Remark
            // 
            this.mnuUnit_Remark.Name = "mnuUnit_Remark";
            this.mnuUnit_Remark.Size = new System.Drawing.Size(154, 22);
            this.mnuUnit_Remark.Tag = "7";
            this.mnuUnit_Remark.Text = "Units && Rem";
            this.mnuUnit_Remark.Click += new System.EventHandler(this.mnuUnit_Remark_Click);
            // 
            // mnuCustomerMaster
            // 
            this.mnuCustomerMaster.Name = "mnuCustomerMaster";
            this.mnuCustomerMaster.Size = new System.Drawing.Size(154, 22);
            this.mnuCustomerMaster.Tag = "8";
            this.mnuCustomerMaster.Text = "Customer";
            this.mnuCustomerMaster.Click += new System.EventHandler(this.mnuCustomerMaster_Click);
            // 
            // mnuSupplier
            // 
            this.mnuSupplier.Name = "mnuSupplier";
            this.mnuSupplier.Size = new System.Drawing.Size(154, 22);
            this.mnuSupplier.Text = "Suplier";
            this.mnuSupplier.Click += new System.EventHandler(this.mnuSupplier_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalesReport,
            this.mnuPurchaseReport,
            this.mnuLedger,
            this.mnuStock,
            this.mnuCashBook,
            this.mnuBankBook,
            this.mnuCashTray,
            this.mnuSalesCash});
            this.mnuReports.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuReports.ForeColor = System.Drawing.Color.Black;
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Size = new System.Drawing.Size(67, 21);
            this.mnuReports.Text = "Reports";
            // 
            // mnuSalesReport
            // 
            this.mnuSalesReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnusalesrpt,
            this.mnusalesmargin,
            this.mnuitemsalesreport,
            this.mnuDaywise});
            this.mnuSalesReport.Name = "mnuSalesReport";
            this.mnuSalesReport.Size = new System.Drawing.Size(155, 22);
            this.mnuSalesReport.Text = "Sales ";
            // 
            // mnusalesrpt
            // 
            this.mnusalesrpt.Name = "mnusalesrpt";
            this.mnusalesrpt.Size = new System.Drawing.Size(155, 22);
            this.mnusalesrpt.Text = "Sales";
            this.mnusalesrpt.Click += new System.EventHandler(this.mnusalesrpt_Click);
            // 
            // mnusalesmargin
            // 
            this.mnusalesmargin.Name = "mnusalesmargin";
            this.mnusalesmargin.Size = new System.Drawing.Size(155, 22);
            this.mnusalesmargin.Text = "Sales Margin";
            this.mnusalesmargin.Click += new System.EventHandler(this.mnusalesmargin_Click);
            // 
            // mnuitemsalesreport
            // 
            this.mnuitemsalesreport.Name = "mnuitemsalesreport";
            this.mnuitemsalesreport.Size = new System.Drawing.Size(155, 22);
            this.mnuitemsalesreport.Text = "Item Sales";
            this.mnuitemsalesreport.Click += new System.EventHandler(this.mnuitemsalesreport_Click);
            // 
            // mnuDaywise
            // 
            this.mnuDaywise.Name = "mnuDaywise";
            this.mnuDaywise.Size = new System.Drawing.Size(155, 22);
            this.mnuDaywise.Text = "Day Wise";
            this.mnuDaywise.Click += new System.EventHandler(this.mnuDaywise_Click);
            // 
            // mnuPurchaseReport
            // 
            this.mnuPurchaseReport.Name = "mnuPurchaseReport";
            this.mnuPurchaseReport.Size = new System.Drawing.Size(155, 22);
            this.mnuPurchaseReport.Text = "Purchase";
            this.mnuPurchaseReport.Click += new System.EventHandler(this.mnuPurchaseReport_Click);
            // 
            // mnuLedger
            // 
            this.mnuLedger.Name = "mnuLedger";
            this.mnuLedger.Size = new System.Drawing.Size(155, 22);
            this.mnuLedger.Text = "Ledger";
            this.mnuLedger.Click += new System.EventHandler(this.mnuLedger_Click);
            // 
            // mnuStock
            // 
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(155, 22);
            this.mnuStock.Text = "Stock";
            this.mnuStock.Click += new System.EventHandler(this.mnuStock_Click);
            // 
            // mnuCashBook
            // 
            this.mnuCashBook.Name = "mnuCashBook";
            this.mnuCashBook.Size = new System.Drawing.Size(155, 22);
            this.mnuCashBook.Text = "Cash Book";
            this.mnuCashBook.Click += new System.EventHandler(this.mnuCashBook_Click);
            // 
            // mnuBankBook
            // 
            this.mnuBankBook.Name = "mnuBankBook";
            this.mnuBankBook.Size = new System.Drawing.Size(155, 22);
            this.mnuBankBook.Text = "Bank Book";
            this.mnuBankBook.Click += new System.EventHandler(this.mnuBankBook_Click);
            // 
            // mnuCashTray
            // 
            this.mnuCashTray.Name = "mnuCashTray";
            this.mnuCashTray.Size = new System.Drawing.Size(155, 22);
            this.mnuCashTray.Text = "Cash Tray";
            this.mnuCashTray.Click += new System.EventHandler(this.mnuCashTray_Click);
            // 
            // mnuSalesCash
            // 
            this.mnuSalesCash.Name = "mnuSalesCash";
            this.mnuSalesCash.Size = new System.Drawing.Size(155, 22);
            this.mnuSalesCash.Text = "Sales && Cash";
            this.mnuSalesCash.Click += new System.EventHandler(this.mnuSalesCash_Click);
            // 
            // mnuSettings
            // 
            this.mnuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPeriod,
            this.mnuNewUser,
            this.mnuRestore,
            this.mnuTokenSetting,
            this.mnuSynchronize,
            this.mnuLanguage});
            this.mnuSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuSettings.ForeColor = System.Drawing.Color.Black;
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(70, 21);
            this.mnuSettings.Text = "Settings";
            // 
            // mnuPeriod
            // 
            this.mnuPeriod.Name = "mnuPeriod";
            this.mnuPeriod.Size = new System.Drawing.Size(164, 22);
            this.mnuPeriod.Text = "Period Setting";
            this.mnuPeriod.Click += new System.EventHandler(this.mnuPeriod_Click);
            // 
            // mnuNewUser
            // 
            this.mnuNewUser.Name = "mnuNewUser";
            this.mnuNewUser.Size = new System.Drawing.Size(164, 22);
            this.mnuNewUser.Text = "New User";
            this.mnuNewUser.Click += new System.EventHandler(this.mnuNewUser_Click);
            // 
            // mnuRestore
            // 
            this.mnuRestore.Name = "mnuRestore";
            this.mnuRestore.Size = new System.Drawing.Size(164, 22);
            this.mnuRestore.Text = "Restore";
            this.mnuRestore.Click += new System.EventHandler(this.mnuRestore_Click);
            // 
            // mnuTokenSetting
            // 
            this.mnuTokenSetting.Name = "mnuTokenSetting";
            this.mnuTokenSetting.Size = new System.Drawing.Size(164, 22);
            this.mnuTokenSetting.Text = "Token";
            this.mnuTokenSetting.Click += new System.EventHandler(this.mnuTokenSetting_Click);
            // 
            // mnuSynchronize
            // 
            this.mnuSynchronize.Name = "mnuSynchronize";
            this.mnuSynchronize.Size = new System.Drawing.Size(164, 22);
            this.mnuSynchronize.Text = "Synchronize";
            this.mnuSynchronize.Visible = false;
            this.mnuSynchronize.Click += new System.EventHandler(this.mnuSynchronize_Click);
            // 
            // mnuLanguage
            // 
            this.mnuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEnglish,
            this.mnuArabic});
            this.mnuLanguage.Name = "mnuLanguage";
            this.mnuLanguage.Size = new System.Drawing.Size(164, 22);
            this.mnuLanguage.Text = "Language";
            // 
            // mnuEnglish
            // 
            this.mnuEnglish.Name = "mnuEnglish";
            this.mnuEnglish.Size = new System.Drawing.Size(121, 22);
            this.mnuEnglish.Text = "English";
            this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
            // 
            // mnuArabic
            // 
            this.mnuArabic.Name = "mnuArabic";
            this.mnuArabic.Size = new System.Drawing.Size(121, 22);
            this.mnuArabic.Text = "Arabic";
            this.mnuArabic.Click += new System.EventHandler(this.mnuArabic_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.mnuHelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuHelp.ForeColor = System.Drawing.Color.Black;
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(49, 21);
            this.mnuHelp.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripcompany,
            this.stripperiod});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(751, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // stripcompany
            // 
            this.stripcompany.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.stripcompany.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.stripcompany.Name = "stripcompany";
            this.stripcompany.Size = new System.Drawing.Size(4, 17);
            // 
            // stripperiod
            // 
            this.stripperiod.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.stripperiod.Name = "stripperiod";
            this.stripperiod.Size = new System.Drawing.Size(0, 17);
            // 
            // sidebarmenu
            // 
            this.sidebarmenu.BackColor = System.Drawing.Color.White;
            this.sidebarmenu.Controls.Add(this.flowTransaction);
            this.sidebarmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarmenu.Location = new System.Drawing.Point(0, 25);
            this.sidebarmenu.Name = "sidebarmenu";
            this.sidebarmenu.Size = new System.Drawing.Size(365, 395);
            this.sidebarmenu.TabIndex = 9;
            this.sidebarmenu.Visible = false;
            // 
            // flowTransaction
            // 
            this.flowTransaction.AutoScroll = true;
            this.flowTransaction.AutoSize = true;
            this.flowTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowTransaction.Location = new System.Drawing.Point(0, 0);
            this.flowTransaction.Name = "flowTransaction";
            this.flowTransaction.Size = new System.Drawing.Size(365, 395);
            this.flowTransaction.TabIndex = 1;
            this.flowTransaction.Click += new System.EventHandler(this.flowTransaction_Click);
            // 
            // btnhide
            // 
            this.btnhide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhide.Location = new System.Drawing.Point(364, 25);
            this.btnhide.Name = "btnhide";
            this.btnhide.Size = new System.Drawing.Size(38, 30);
            this.btnhide.TabIndex = 11;
            this.btnhide.Text = "<<<";
            this.btnhide.UseVisualStyleBackColor = true;
            this.btnhide.Visible = false;
            this.btnhide.Click += new System.EventHandler(this.btnhide_Click);
            // 
            // synchronizedata
            // 
            this.synchronizedata.WorkerSupportsCancellation = true;
            this.synchronizedata.DoWork += new System.ComponentModel.DoWorkEventHandler(this.synchronizedata_DoWork);
            // 
            // synchronizeitemwise
            // 
            this.synchronizeitemwise.WorkerSupportsCancellation = true;
            this.synchronizeitemwise.DoWork += new System.ComponentModel.DoWorkEventHandler(this.synchronizeitemwise_DoWork);
            // 
            // mainmdi
            // 
            this.BackgroundImage = global::GNetBillingSoft.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 442);
            this.Controls.Add(this.btnhide);
            this.Controls.Add(this.sidebarmenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "mainmdi";
            this.Text = "G-Net Billing Soft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainmdi_FormClosing);
            this.Load += new System.EventHandler(this.mainmdi_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.sidebarmenu.ResumeLayout(false);
            this.sidebarmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ToolStripMenuItem mnuPOS;
        private ToolStripMenuItem mnuUnit_Remark;
        private ToolStripMenuItem mnuCustomerMaster;
        private ToolStripMenuItem mnuSupplier;
        public MenuStrip mnuMain;
        private ToolStripMenuItem mnuNewUser;
        private ToolStripMenuItem mnulogout;
        private ToolStripMenuItem mnuOpenRmtCmp;
        private ToolStripMenuItem mnuitemsalesreport;
        private ToolStripMenuItem mnuCashTray;
        private ToolStripMenuItem mnuRestore;
        private ToolStripMenuItem mnuTokenSetting;
        private ToolStripMenuItem mnuSalesCash;
        private Panel sidebarmenu;
        private FlowLayoutPanel flowTransaction;
        private Button btnhide;
        private ToolStripMenuItem mnuSynchronize;
        public BackgroundWorker synchronizedata;
        private ToolStripMenuItem mnuDaywise;
        public BackgroundWorker synchronizeitemwise;
        private ToolStripMenuItem mnuLanguage;
        private ToolStripMenuItem mnuEnglish;
        private ToolStripMenuItem mnuArabic;
        private ToolStripMenuItem mnuLedger;

    }
      
}
