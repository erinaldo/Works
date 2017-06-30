using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
using System.Reflection;
namespace GNetBillingSoft
{
    public partial class mainmdi : Form
    {
        clsuserinfo userinf = new clsuserinfo();
        clsServerOperation server = new clsServerOperation();
        public long userid = 0;
       
        public mainmdi()
        {
            InitializeComponent();
            mnuMaster.Visible = false;
            mnuTransactions.Visible = false;
            mnuReports.Visible = false;
            mnuSettings.Visible = false;
            userinf.SetMenuTag(this.mnuMain);
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            //this.Text = "";

            //Menu
            //File Menu
            this.mnuFile.Text = "ملف";
            this.mnuNewCompany.Text = "شركة جديدة";
            this.mnuOpenCompany.Text = "فتح الشركة";
            this.mnuOpenRmtCmp.Text = "فتح شركة البعيد";
            this.mnulogout.Text = "الخروج";
            this.mnuExit.Text = "ىخرج";

            //Master Menu
            this.mnuMaster.Text = "بيانات الاساسية";
            this.mnuitems.Text = "(رقم المادة(الصنف";
            this.mnuUnit_Remark.Text = "وحدات وملاحظات";
            this.mnuCustomerMaster.Text = "عميل";
            this.mnuSupplier.Text = "مورد";

            //Transaction Menu
            this.mnuTransactions.Text = "المعاملات";
            this.salesToolStripMenuItem.Text = "المبيعات";
            this.mnuSalesInvoice.Text = "فاتورة المبيعات";
            this.mnuSalesReturn.Text = "مردودات المبيعات";
            this.mnuPOS.Text = "نقطة المبيعات";
            this.purchaseToolStripMenuItem.Text = "الشراء";
            this.mnuPurchaseInvoice.Text = "المشتريات";
            this.mnuPurchaseReturn.Text = "مردودات المشتريات";
            this.mnuVoucher.Text = "إيصال";
            this.mnuLedger.Text = "(سجل حسابات(دفتر الاستاذ";

            //Report Menu
            this.mnuReports.Text = "التقارير";
            this.mnuSalesReport.Text = "المبيعات";
            this.mnusalesrpt.Text = "المبيعات";
            this.mnusalesmargin.Text = "تقرير هامش المبيعات";
            this.mnuitemsalesreport.Text = "تقرير مبيعات البند";
            this.mnuDaywise.Text = "يوم تقرير الحكيم";
            this.mnuPurchaseReport.Text = "الشراء";
            this.mnuStock.Text = "المخزون";
            this.mnuCashBook.Text = "نقد في اليد";
            this.mnuBankBook.Text = "النقد في البنك";
            this.mnuCashTray.Text = "علبة النقدية";
            this.mnuSalesCash.Text = "المبيعات والنقدية";

            //Settings Menu
            this.mnuSettings.Text = "إعدادات";
            this.mnuPeriod.Text = "إعداد الفترة";
            this.mnuNewUser.Text = "مستخدم جديد";
            this.mnuRestore.Text = "استعادة";
            this.mnuTokenSetting.Text = "تم حفظ إعدادات الرموز ";
            this.mnuSynchronize.Text = "تزامن البيانات";
            this.mnuArabic.Text = " العربى";

            //Help Menu
            this.mnuHelp.Text = "مساعدة";
        }
      
        private void mnuSalesInvoice_Click(object sender, EventArgs e)
        {
            //FormCollection fc = Application.OpenForms;
            //bool FormFound = false;
            //foreach (Form frm in fc)
            //{
            //    if (frm.Name == "frmSalesinvoice")
            //    {
            //        frm.Focus();
            //        FormFound = true;
            //    }
            //}

            //if (FormFound == false)
            //{
                Transactions.frmSalesinvoice sales = new Transactions.frmSalesinvoice();
                sales.MdiParent = this;
                sales.WindowState = FormWindowState.Maximized;
                sales.Show();
            //}
        }

        private void mnuSalesReturn_Click(object sender, EventArgs e)
        {
            Transactions.frmSalesReturn salesreturn = new Transactions.frmSalesReturn();
            salesreturn.MdiParent = this;
            salesreturn.WindowState = FormWindowState.Maximized;
            salesreturn.Show();
            
        }

        private void mnuPurchaseInvoice_Click(object sender, EventArgs e)
        {
            Transactions.frmPurchaseInvoice purchase = new Transactions.frmPurchaseInvoice();
            purchase.MdiParent = this;
            purchase.WindowState = FormWindowState.Maximized;
            purchase.Show();
           
        }

        private void mnuPurchaseReturn_Click(object sender, EventArgs e)
        {
            Transactions.frmPurchaseReturn purchasereturn = new Transactions.frmPurchaseReturn();
            purchasereturn.MdiParent = this;
            purchasereturn.WindowState = FormWindowState.Maximized;
            purchasereturn.Show();
           
        }

        private void mnuNewCompany_Click(object sender, EventArgs e)
        {
            frmnewCompany newcmp = new frmnewCompany();
            MenuDefault(false);
            dboperation.ClearConnection();
            newcmp.ShowDialog();
            if (clsproperties.Finish)
            {
                frmCreateNewcomp frmCreate = new frmCreateNewcomp();
                frmCreate.ShowDialog();
                if (clsproperties.Finish)
                {
                    String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "يتم تعيين هذه الشركة إلى الشركة الافتراضية الخاصة بك" : "This company is set to your default company";
                    MessageBox.Show(Msg);
                    Properties.Settings.Default.Defaultcompany = dboperation.GetServer();

                    Properties.Settings.Default.Save();
                    frmLogin frmlogin = new frmLogin(mnuMain);
                    DialogResult result = frmlogin.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                       
                        MenuDefault(true);
                        flowTransaction.Controls.Clear();
                        if (clsuserroles.UId != 1 && clsuserroles.UId != 0)
                        {
                            clsuserroles role = new clsuserroles();

                            role.userid = clsuserroles.UId;
                            role.SetMenus(role.userid, mnuMain);
                            
                            role.AddSideMenu(flowTransaction, CallEvent, mnuMain, null, role.userid);
                            mnulogout.Visible = true;
                            btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                            btnhide.Visible = true;
                            sidebarmenu.Visible = true;
                        }
                        else
                        {
                            clsuserroles role = new clsuserroles();
                            role.AddSideMenu(flowTransaction, CallEvent, mnuMain, null);
                            mnulogout.Visible = true;
                            btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                            btnhide.Visible = true;
                            sidebarmenu.Visible = true;
                        }

                       

                        SetCompanyInfo();
                        synchronizedata.RunWorkerAsync();
                        synchronizeitemwise.RunWorkerAsync();
                    }
                }

              
            }
        }
        public void MenuDefault(bool status)
        {
            mnuMaster.Visible = status;
            mnuTransactions.Visible = status;
            mnuReports.Visible = status;
            mnuSettings.Visible = status;
            mnuHelp.Visible = true;
            
        }
        private void mnuVoucher_Click(object sender, EventArgs e)
        {
            Transactions.frmVoucher voucher = new Transactions.frmVoucher();
            voucher.MdiParent = this;
            voucher.Show();
            
        }

        private void mnuStock_Click(object sender, EventArgs e)
        {
            Reports.frmStockReport frm = new Reports.frmStockReport();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void mnuPurchaseReport_Click(object sender, EventArgs e)
        {
            Reports.frmPurchaseReport frm = new Reports.frmPurchaseReport();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            synchronizedata.CancelAsync();
            synchronizeitemwise.CancelAsync();
            Application.Exit();
        }

        private void mnuCashBook_Click(object sender, EventArgs e)
        {
            Reports.frmCashBook frm = new Reports.frmCashBook();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void mnuBankBook_Click(object sender, EventArgs e)
        {
            Reports.frmBankBook frm = new Reports.frmBankBook();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuitems_Click(object sender, EventArgs e)
        {
            Master.frmItemMaster frm = new Master.frmItemMaster();
            frm.MdiParent = this;
            
            frm.Show();
        }

        private void mnuOpenCompany_Click(object sender, EventArgs e)
        {
            frmOpenCmp frm = new frmOpenCmp();
            //frm.MdiParent = this;
            MenuDefault(false);
           DialogResult resultopen= frm.ShowDialog();
           if (resultopen == DialogResult.OK)
           {
               frmLogin frmlogin = new frmLogin(mnuMain);
               DialogResult result = frmlogin.ShowDialog();
               if (result == DialogResult.OK)
               {
                   MenuDefault(true);
                   flowTransaction.Controls.Clear();
                   if (clsuserroles.UId != 1 && clsuserroles.UId != 0)
                   {
                       clsuserroles role = new clsuserroles();
                       role.userid = clsuserroles.UId;
                       role.SetMenus(role.userid, mnuMain);
                       
                       role.AddSideMenu(flowTransaction, CallEvent, mnuMain, null, role.userid);
                       mnulogout.Visible = true;
                       btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                       btnhide.Visible = true;
                       sidebarmenu.Visible = true;
                   }
                   else
                   {
                       clsuserroles role = new clsuserroles();
                       role.AddSideMenu(flowTransaction, CallEvent, mnuMain, null);
                       mnulogout.Visible = true;
                       btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                       btnhide.Visible = true;
                       sidebarmenu.Visible = true;
                   }
                   SetCompanyInfo();
                   synchronizedata.RunWorkerAsync();
                   synchronizeitemwise.RunWorkerAsync();
               }
               else
               {
                   dboperation.ClearConnection();
               }
           }
           else
           {
               dboperation.ClearConnection();
               SetCompanyInfo(false);
           }
            
        }

        private void mainmdi_Load(object sender, EventArgs e)
        {
            string defaultcmp = Properties.Settings.Default.Defaultcompany;

            if (defaultcmp != "")
            {
                dboperation.setDefault();
                frmLogin frm = new frmLogin(mnuMain);
                
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MenuDefault(true);
                    if (clsuserroles.UId != 1 && clsuserroles.UId != 0)
                    {
                        clsuserroles role = new clsuserroles();
                        role.userid = clsuserroles.UId;
                        clsuserroles.UId = 0;
                        role.SetMenus(role.userid, mnuMain);
                        flowTransaction.Controls.Clear();
                        role.AddSideMenu(flowTransaction, CallEvent, mnuMain,null,role.userid);
                        mnulogout.Visible = true;
                        //role.AddSideMenu(sidebar, mnuMain);
                    }
                    else if(clsuserroles.UId==1)
                    {
                        clsuserroles.UId = 0;
                        clsuserroles role = new clsuserroles();
                        flowTransaction.Controls.Clear();
                        role.AddSideMenu(flowTransaction,CallEvent, mnuMain);
                    }
                    btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                    btnhide.Visible = true;
                    sidebarmenu.Visible = true;
                    
                    SetCompanyInfo();
                    synchronizedata.RunWorkerAsync();
                    synchronizeitemwise.RunWorkerAsync();
                }
                
            }
        }

        
        public void SetCompanyInfo(bool status=true)
        {
            if (status)
            {
                clscompanyinfo cmpinfo = new clscompanyinfo();
                clsperiodinfo period = new clsperiodinfo();
                DataTable dt = cmpinfo.GetRecord();
                stripcompany.Text =(dt.Rows[0]["displayname"].ToString()!=null && dt.Rows[0]["displayname"].ToString()!="")?dt.Rows[0]["displayname"].ToString(): dt.Rows[0]["companyname"].ToString();
                DataTable per = period.GetRecord();
                DateTime dtfrom = Convert.ToDateTime(per.Rows[0]["periodstart"]);
                DateTime dtTo = Convert.ToDateTime(per.Rows[0]["periodend"]);
                stripperiod.Text = "";
               
                stripperiod.Text = dtfrom.ToString("dd/MM/yyyy") + " to " + dtTo.ToString("dd/MM/yyyy");
            }
            else
            {
                stripcompany.Text = "";
                stripperiod.Text = "";
            }

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnusalesrpt_Click(object sender, EventArgs e)
        {
            frmSalesReport frm = new frmSalesReport();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void mnusalesmargin_Click(object sender, EventArgs e)
        {
            Reports.frmSalesMargin frm = new Reports.frmSalesMargin();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void mnuLedger_Click(object sender, EventArgs e)
        {
            Reports.frmLedger frm = new Reports.frmLedger();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void mnuPeriod_Click(object sender, EventArgs e)
        {
            Settings.frmPeriod frm = new Settings.frmPeriod();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void mnuPOS_Click(object sender, EventArgs e)
        {

            //frmNewPOS fnp = new frmNewPOS();
            //fnp.WindowState = FormWindowState.Maximized;
            //fnp.Show();

            Transactions.frmPOS frm = new Transactions.frmPOS();
            frm.WindowState = FormWindowState.Maximized;
            try
            {
                frm.Show();
            }
            catch (Exception)
            {
                frm.Show();
            }
            //spltmain.Panel2.Controls.Add(frm);

            //TestRawInput frm = new TestRawInput();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void mnuUnit_Remark_Click(object sender, EventArgs e)
        {
            Master.frmUnits_Remarks frm = new Master.frmUnits_Remarks();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void mnuCustomerMaster_Click(object sender, EventArgs e)
        {
            Master.frmCustomer frm = new Master.frmCustomer();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            Master.frmSuplier frm = new Master.frmSuplier();
            frm.MdiParent = this;
            frm.Show();
           
        }

        private void mnuNewUser_Click(object sender, EventArgs e)
        {
            Settings.frmuser frm = new Settings.frmuser(mnuMain);
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void mnulogout_Click(object sender, EventArgs e)
        {
            try
            {
                dboperation.setDefault();
                MenuDefault(false);
                sidebarmenu.Hide();
                btnhide.Visible = false;
                synchronizedata.CancelAsync();
                synchronizeitemwise.CancelAsync();
                frmLogin frm = new frmLogin(mnuMain);
                
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MenuDefault(true);
                    flowTransaction.Controls.Clear();
                    if (clsuserroles.UId != 1 && clsuserroles.UId != 0)
                    {
                        clsuserroles role = new clsuserroles();
                        role.userid = clsuserroles.UId;
                        clsuserroles.UId = 0;
                        role.SetMenus(role.userid, mnuMain);
                       
                        role.AddSideMenu(flowTransaction, CallEvent, mnuMain, null, role.userid);
                       
                        mnulogout.Visible = true;
                    }
                    else if(clsuserroles.UId==1)
                    {
                        clsuserroles.UId = 0;
                        clsuserroles role = new clsuserroles();
                        role.AddSideMenu(flowTransaction, CallEvent, mnuMain, null);
                        mnulogout.Visible = true;
                        btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                        btnhide.Visible = true;
                        sidebarmenu.Visible = true;
                    }
                    btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                    btnhide.Visible = true;
                    sidebarmenu.Visible = true;
                    SetCompanyInfo();
                    synchronizedata.RunWorkerAsync();
                    synchronizeitemwise.RunWorkerAsync();
                }
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        private void mnuOpenRmtCmp_Click(object sender, EventArgs e)
        {
            frmOpnRmt frm = new frmOpnRmt();
            MenuDefault(false);
            DialogResult resultopen = frm.ShowDialog();
            if (resultopen == DialogResult.OK)
            {
                frmLogin frmlogin = new frmLogin(mnuMain);
                DialogResult result = frmlogin.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MenuDefault(true);
                    flowTransaction.Controls.Clear();
                    if (clsuserroles.UId != 1 && clsuserroles.UId != 0)
                    {
                        clsuserroles role = new clsuserroles();
                        role.userid = clsuserroles.UId;
                        role.SetMenus(role.userid, mnuMain);

                        role.AddSideMenu(flowTransaction, CallEvent, mnuMain, null, role.userid);
                        mnulogout.Visible = true;
                        btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                        btnhide.Visible = true;
                        sidebarmenu.Visible = true;
                    }
                    else
                    {
                        clsuserroles role = new clsuserroles();
                        role.AddSideMenu(flowTransaction, CallEvent, mnuMain, null, role.userid);
                        mnulogout.Visible = true;
                        btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                        btnhide.Visible = true;
                        sidebarmenu.Visible = true;
                    }
                    SetCompanyInfo();
                    synchronizedata.RunWorkerAsync();
                    synchronizeitemwise.RunWorkerAsync();
                }
                else
                {
                    dboperation.ClearConnection();
                }

            }
            else
            {
                dboperation.ClearConnection();
                SetCompanyInfo(false);
            }
        }

        private void mnuitemsalesreport_Click(object sender, EventArgs e)
        {
            Reports.frmItemSales frm = new Reports.frmItemSales();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void mainmdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            synchronizedata.CancelAsync();
            synchronizeitemwise.CancelAsync();
        }

        private void mnuCashTray_Click(object sender, EventArgs e)
        {
            Reports.frmcashtray frm = new Reports.frmcashtray();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void mnuRestore_Click(object sender, EventArgs e)
        {
            frmOpenCmp open = new frmOpenCmp();
            
            open.dlgOpen.Filter = "Back Up(*.bak)|*.bak";
            DialogResult dlg = open.dlgOpen.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                synchronizedata.CancelAsync();
                synchronizeitemwise.CancelAsync();
                clsDBCreator.Restore(open.dlgOpen);
            }
        }

        private void mnuTokenSetting_Click(object sender, EventArgs e)
        {
            Settings.frmToken frm = new Settings.frmToken();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void mnuSalesCash_Click(object sender, EventArgs e)
        {
            frmsalescashsummary frm = new frmsalescashsummary();
            frm.MdiParent = this;
            frm.Show();
            
        }

        public  void CallEvent(object sender,EventArgs e)
        {
            foreach (Control ctrl in this.flowTransaction.Controls)
                if (ctrl is Button)
                {
                    ctrl.BackColor = Color.White;
                    ctrl.ForeColor = Color.Black;
                }
            Button btn = (Button)sender;
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.White;
            MethodInfo theMethod = typeof(mainmdi).GetMethod(btn.Name + "_Click",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase);
            
          
            theMethod.Invoke(this, new object[] { sender, e });
           
        }

        private void flowTransaction_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mnuitems_Click(sender, e);

        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            if (sidebarmenu.Visible)
            {
                sidebarmenu.Hide();

                btnhide.Location = new Point(0, mnuMain.Height);
                btnhide.Text = ">>>";
            }
            else
            {
                sidebarmenu.Show();

                btnhide.Location = new Point(sidebarmenu.Width, mnuMain.Height);
                btnhide.Text = "<<<";
            }
            

        }

        private void mnuSynchronize_Click(object sender, EventArgs e)
        {
            Settings.frmServerSync frm = new Settings.frmServerSync();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuEnglish_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Lang == "Arabic")
            {
                Properties.Settings.Default.Lang = "English";
                Properties.Settings.Default.Save();

                DialogResult dialogResult = MessageBox.Show("تغيير اللغة .. الرجاء إعادة تشغيل التطبيق", "Restart", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
            }
        }
        private void mnuArabic_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Lang == "English")
            {
                Properties.Settings.Default.Lang = "Arabic";
                Properties.Settings.Default.Save();
                DialogResult dialogResult = MessageBox.Show("Language Changed..Please Restart Application", "Restart", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
            }
        }

        private void synchronizedata_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = server.SynchronizeData(worker);

            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        //private void flowTransaction_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void mnuDaywise_Click(object sender, EventArgs e)
        {
            Reports.frmDayWise frm = new Reports.frmDayWise();
            frm.MdiParent = this;
            frm.Show();
        }

        private void synchronizeitemwise_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = server.SynchronizeitemData(worker);

            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
        }
    }
}
