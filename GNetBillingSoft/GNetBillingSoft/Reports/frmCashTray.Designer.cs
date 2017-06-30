namespace GNetBillingSoft.Reports
{
    partial class frmcashtray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.lblemployee = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblEmploy = new System.Windows.Forms.Label();
            this.lblDate1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvdescription = new System.Windows.Forms.DataGridView();
            this.grpCashInfo = new System.Windows.Forms.GroupBox();
            this.txtshort = new System.Windows.Forms.TextBox();
            this.txtcashamtdue = new System.Windows.Forms.TextBox();
            this.txtgrosscash = new System.Windows.Forms.TextBox();
            this.txtcashamount = new System.Windows.Forms.TextBox();
            this.txtnetcashdue = new System.Windows.Forms.TextBox();
            this.txtemppaidout = new System.Windows.Forms.TextBox();
            this.txtmoneydrp = new System.Windows.Forms.TextBox();
            this.txtcashback = new System.Windows.Forms.TextBox();
            this.txtcreditcash = new System.Windows.Forms.TextBox();
            this.txtlesstips = new System.Windows.Forms.TextBox();
            this.txtpaidouts = new System.Windows.Forms.TextBox();
            this.txtpaidins = new System.Windows.Forms.TextBox();
            this.lblPaidOut = new System.Windows.Forms.Label();
            this.lblLessTip = new System.Windows.Forms.Label();
            this.lblCCTFee = new System.Windows.Forms.Label();
            this.lblCashBack = new System.Windows.Forms.Label();
            this.lblEmpPaidOut = new System.Windows.Forms.Label();
            this.lblBCAmt = new System.Windows.Forms.Label();
            this.lblGCDue = new System.Windows.Forms.Label();
            this.lblMoneyDrop = new System.Windows.Forms.Label();
            this.lblNetCashDue = new System.Windows.Forms.Label();
            this.lblECADue = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblPaidIn = new System.Windows.Forms.Label();
            this.lblcashrevenu = new System.Windows.Forms.Label();
            this.lblCashRev = new System.Windows.Forms.Label();
            this.grpNCInfo = new System.Windows.Forms.GroupBox();
            this.lbltotshort = new System.Windows.Forms.Label();
            this.lbltotcashtry = new System.Windows.Forms.Label();
            this.lblnetcash = new System.Windows.Forms.Label();
            this.lblTCTray = new System.Windows.Forms.Label();
            this.lblTotalShort = new System.Windows.Forms.Label();
            this.lblNCChecks = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescription)).BeginInit();
            this.grpCashInfo.SuspendLayout();
            this.grpNCInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.lblemployee);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Controls.Add(this.lblTime1);
            this.groupBox1.Controls.Add(this.lblEmploy);
            this.groupBox1.Controls.Add(this.lblDate1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(281, 16);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(38, 15);
            this.lbltime.TabIndex = 5;
            this.lbltime.Text = "label6";
            // 
            // lblemployee
            // 
            this.lblemployee.AutoSize = true;
            this.lblemployee.Location = new System.Drawing.Point(78, 51);
            this.lblemployee.Name = "lblemployee";
            this.lblemployee.Size = new System.Drawing.Size(38, 15);
            this.lblemployee.TabIndex = 4;
            this.lblemployee.Text = "label5";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(78, 16);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(38, 15);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "label4";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTime1.Location = new System.Drawing.Point(239, 16);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(35, 15);
            this.lblTime1.TabIndex = 2;
            this.lblTime1.Text = "Time";
            // 
            // lblEmploy
            // 
            this.lblEmploy.AutoSize = true;
            this.lblEmploy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmploy.Location = new System.Drawing.Point(13, 51);
            this.lblEmploy.Name = "lblEmploy";
            this.lblEmploy.Size = new System.Drawing.Size(61, 15);
            this.lblEmploy.TabIndex = 1;
            this.lblEmploy.Text = "Employee";
            // 
            // lblDate1
            // 
            this.lblDate1.AutoSize = true;
            this.lblDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate1.Location = new System.Drawing.Point(14, 16);
            this.lblDate1.Name = "lblDate1";
            this.lblDate1.Size = new System.Drawing.Size(37, 15);
            this.lblDate1.TabIndex = 0;
            this.lblDate1.Text = "Date ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvdescription);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(371, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvdescription
            // 
            this.dgvdescription.AllowUserToDeleteRows = false;
            this.dgvdescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdescription.BackgroundColor = System.Drawing.Color.White;
            this.dgvdescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdescription.Location = new System.Drawing.Point(3, 19);
            this.dgvdescription.Name = "dgvdescription";
            this.dgvdescription.ReadOnly = true;
            this.dgvdescription.Size = new System.Drawing.Size(316, 167);
            this.dgvdescription.TabIndex = 20;
            // 
            // grpCashInfo
            // 
            this.grpCashInfo.Controls.Add(this.txtshort);
            this.grpCashInfo.Controls.Add(this.txtcashamtdue);
            this.grpCashInfo.Controls.Add(this.txtgrosscash);
            this.grpCashInfo.Controls.Add(this.txtcashamount);
            this.grpCashInfo.Controls.Add(this.txtnetcashdue);
            this.grpCashInfo.Controls.Add(this.txtemppaidout);
            this.grpCashInfo.Controls.Add(this.txtmoneydrp);
            this.grpCashInfo.Controls.Add(this.txtcashback);
            this.grpCashInfo.Controls.Add(this.txtcreditcash);
            this.grpCashInfo.Controls.Add(this.txtlesstips);
            this.grpCashInfo.Controls.Add(this.txtpaidouts);
            this.grpCashInfo.Controls.Add(this.txtpaidins);
            this.grpCashInfo.Controls.Add(this.lblPaidOut);
            this.grpCashInfo.Controls.Add(this.lblLessTip);
            this.grpCashInfo.Controls.Add(this.lblCCTFee);
            this.grpCashInfo.Controls.Add(this.lblCashBack);
            this.grpCashInfo.Controls.Add(this.lblEmpPaidOut);
            this.grpCashInfo.Controls.Add(this.lblBCAmt);
            this.grpCashInfo.Controls.Add(this.lblGCDue);
            this.grpCashInfo.Controls.Add(this.lblMoneyDrop);
            this.grpCashInfo.Controls.Add(this.lblNetCashDue);
            this.grpCashInfo.Controls.Add(this.lblECADue);
            this.grpCashInfo.Controls.Add(this.lblShort);
            this.grpCashInfo.Controls.Add(this.lblPaidIn);
            this.grpCashInfo.Controls.Add(this.lblcashrevenu);
            this.grpCashInfo.Controls.Add(this.lblCashRev);
            this.grpCashInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpCashInfo.Location = new System.Drawing.Point(2, 199);
            this.grpCashInfo.Name = "grpCashInfo";
            this.grpCashInfo.Size = new System.Drawing.Size(484, 236);
            this.grpCashInfo.TabIndex = 2;
            this.grpCashInfo.TabStop = false;
            this.grpCashInfo.Text = "Cash Information";
            // 
            // txtshort
            // 
            this.txtshort.Location = new System.Drawing.Point(388, 178);
            this.txtshort.Name = "txtshort";
            this.txtshort.Size = new System.Drawing.Size(82, 23);
            this.txtshort.TabIndex = 13;
            this.txtshort.Text = "0";
            this.txtshort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtshort.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtshort_PreviewKeyDown);
            // 
            // txtcashamtdue
            // 
            this.txtcashamtdue.Location = new System.Drawing.Point(388, 147);
            this.txtcashamtdue.Name = "txtcashamtdue";
            this.txtcashamtdue.Size = new System.Drawing.Size(82, 23);
            this.txtcashamtdue.TabIndex = 12;
            this.txtcashamtdue.Text = "0";
            this.txtcashamtdue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtgrosscash
            // 
            this.txtgrosscash.Location = new System.Drawing.Point(138, 207);
            this.txtgrosscash.Name = "txtgrosscash";
            this.txtgrosscash.Size = new System.Drawing.Size(90, 23);
            this.txtgrosscash.TabIndex = 7;
            this.txtgrosscash.Text = "0";
            this.txtgrosscash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtcashamount
            // 
            this.txtcashamount.Location = new System.Drawing.Point(138, 180);
            this.txtcashamount.Name = "txtcashamount";
            this.txtcashamount.Size = new System.Drawing.Size(90, 23);
            this.txtcashamount.TabIndex = 6;
            this.txtcashamount.Text = "500";
            this.txtcashamount.TextChanged += new System.EventHandler(this.txtcashamount_TextChanged);
            this.txtcashamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtnetcashdue
            // 
            this.txtnetcashdue.Location = new System.Drawing.Point(138, 146);
            this.txtnetcashdue.Name = "txtnetcashdue";
            this.txtnetcashdue.Size = new System.Drawing.Size(90, 23);
            this.txtnetcashdue.TabIndex = 5;
            this.txtnetcashdue.Text = "0";
            this.txtnetcashdue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtemppaidout
            // 
            this.txtemppaidout.Location = new System.Drawing.Point(387, 102);
            this.txtemppaidout.Name = "txtemppaidout";
            this.txtemppaidout.Size = new System.Drawing.Size(82, 23);
            this.txtemppaidout.TabIndex = 11;
            this.txtemppaidout.Tag = "sub";
            this.txtemppaidout.Text = "0";
            this.txtemppaidout.TextChanged += new System.EventHandler(this.CalcNetCash);
            this.txtemppaidout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtmoneydrp
            // 
            this.txtmoneydrp.Location = new System.Drawing.Point(388, 76);
            this.txtmoneydrp.Name = "txtmoneydrp";
            this.txtmoneydrp.Size = new System.Drawing.Size(82, 23);
            this.txtmoneydrp.TabIndex = 10;
            this.txtmoneydrp.Tag = "add";
            this.txtmoneydrp.Text = "0";
            this.txtmoneydrp.TextChanged += new System.EventHandler(this.CalcNetCash);
            this.txtmoneydrp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtcashback
            // 
            this.txtcashback.Location = new System.Drawing.Point(388, 50);
            this.txtcashback.Name = "txtcashback";
            this.txtcashback.Size = new System.Drawing.Size(82, 23);
            this.txtcashback.TabIndex = 9;
            this.txtcashback.Tag = "sub";
            this.txtcashback.Text = "0";
            this.txtcashback.TextChanged += new System.EventHandler(this.CalcNetCash);
            this.txtcashback.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtcreditcash
            // 
            this.txtcreditcash.Location = new System.Drawing.Point(388, 24);
            this.txtcreditcash.Name = "txtcreditcash";
            this.txtcreditcash.Size = new System.Drawing.Size(82, 23);
            this.txtcreditcash.TabIndex = 8;
            this.txtcreditcash.Tag = "add";
            this.txtcreditcash.Text = "0";
            this.txtcreditcash.TextChanged += new System.EventHandler(this.CalcNetCash);
            this.txtcreditcash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtlesstips
            // 
            this.txtlesstips.Location = new System.Drawing.Point(138, 102);
            this.txtlesstips.Name = "txtlesstips";
            this.txtlesstips.Size = new System.Drawing.Size(90, 23);
            this.txtlesstips.TabIndex = 4;
            this.txtlesstips.Tag = "sub";
            this.txtlesstips.Text = "0";
            this.txtlesstips.TextChanged += new System.EventHandler(this.CalcNetCash);
            this.txtlesstips.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtpaidouts
            // 
            this.txtpaidouts.Location = new System.Drawing.Point(138, 76);
            this.txtpaidouts.Name = "txtpaidouts";
            this.txtpaidouts.Size = new System.Drawing.Size(90, 23);
            this.txtpaidouts.TabIndex = 3;
            this.txtpaidouts.Tag = "sub";
            this.txtpaidouts.Text = "0";
            this.txtpaidouts.TextChanged += new System.EventHandler(this.CalcNetCash);
            this.txtpaidouts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtpaidins
            // 
            this.txtpaidins.Location = new System.Drawing.Point(138, 49);
            this.txtpaidins.Name = "txtpaidins";
            this.txtpaidins.Size = new System.Drawing.Size(90, 23);
            this.txtpaidins.TabIndex = 2;
            this.txtpaidins.Tag = "add";
            this.txtpaidins.Text = "0";
            this.txtpaidins.TextChanged += new System.EventHandler(this.CalcNetCash);
            this.txtpaidins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblPaidOut
            // 
            this.lblPaidOut.AutoSize = true;
            this.lblPaidOut.Location = new System.Drawing.Point(14, 79);
            this.lblPaidOut.Name = "lblPaidOut";
            this.lblPaidOut.Size = new System.Drawing.Size(62, 15);
            this.lblPaidOut.TabIndex = 13;
            this.lblPaidOut.Text = "Paid Outs ";
            // 
            // lblLessTip
            // 
            this.lblLessTip.AutoSize = true;
            this.lblLessTip.Location = new System.Drawing.Point(14, 105);
            this.lblLessTip.Name = "lblLessTip";
            this.lblLessTip.Size = new System.Drawing.Size(58, 15);
            this.lblLessTip.TabIndex = 12;
            this.lblLessTip.Text = "Less Tips ";
            // 
            // lblCCTFee
            // 
            this.lblCCTFee.AutoSize = true;
            this.lblCCTFee.Location = new System.Drawing.Point(245, 27);
            this.lblCCTFee.Name = "lblCCTFee";
            this.lblCCTFee.Size = new System.Drawing.Size(112, 15);
            this.lblCCTFee.TabIndex = 11;
            this.lblCCTFee.Text = "Credit Card Tip Fee";
            // 
            // lblCashBack
            // 
            this.lblCashBack.AutoSize = true;
            this.lblCashBack.Location = new System.Drawing.Point(245, 56);
            this.lblCashBack.Name = "lblCashBack";
            this.lblCashBack.Size = new System.Drawing.Size(62, 15);
            this.lblCashBack.TabIndex = 10;
            this.lblCashBack.Text = "Cash Back";
            // 
            // lblEmpPaidOut
            // 
            this.lblEmpPaidOut.AutoSize = true;
            this.lblEmpPaidOut.Location = new System.Drawing.Point(245, 105);
            this.lblEmpPaidOut.Name = "lblEmpPaidOut";
            this.lblEmpPaidOut.Size = new System.Drawing.Size(111, 15);
            this.lblEmpPaidOut.TabIndex = 9;
            this.lblEmpPaidOut.Text = "Employee Paid Out";
            // 
            // lblBCAmt
            // 
            this.lblBCAmt.AutoSize = true;
            this.lblBCAmt.Location = new System.Drawing.Point(14, 183);
            this.lblBCAmt.Name = "lblBCAmt";
            this.lblBCAmt.Size = new System.Drawing.Size(115, 15);
            this.lblBCAmt.TabIndex = 8;
            this.lblBCAmt.Text = "Being Cash Amount";
            // 
            // lblGCDue
            // 
            this.lblGCDue.AutoSize = true;
            this.lblGCDue.Location = new System.Drawing.Point(14, 210);
            this.lblGCDue.Name = "lblGCDue";
            this.lblGCDue.Size = new System.Drawing.Size(92, 15);
            this.lblGCDue.TabIndex = 7;
            this.lblGCDue.Text = "Gross Cash Due";
            // 
            // lblMoneyDrop
            // 
            this.lblMoneyDrop.AutoSize = true;
            this.lblMoneyDrop.Location = new System.Drawing.Point(245, 79);
            this.lblMoneyDrop.Name = "lblMoneyDrop";
            this.lblMoneyDrop.Size = new System.Drawing.Size(81, 15);
            this.lblMoneyDrop.TabIndex = 6;
            this.lblMoneyDrop.Text = "Money Drops";
            // 
            // lblNetCashDue
            // 
            this.lblNetCashDue.AutoSize = true;
            this.lblNetCashDue.Location = new System.Drawing.Point(14, 154);
            this.lblNetCashDue.Name = "lblNetCashDue";
            this.lblNetCashDue.Size = new System.Drawing.Size(85, 15);
            this.lblNetCashDue.TabIndex = 5;
            this.lblNetCashDue.Text = "Net Cash Due ";
            // 
            // lblECADue
            // 
            this.lblECADue.AutoSize = true;
            this.lblECADue.Location = new System.Drawing.Point(245, 150);
            this.lblECADue.Name = "lblECADue";
            this.lblECADue.Size = new System.Drawing.Size(129, 15);
            this.lblECADue.TabIndex = 4;
            this.lblECADue.Text = "End Cash Amount Due";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(245, 181);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(38, 15);
            this.lblShort.TabIndex = 3;
            this.lblShort.Text = "Short";
            // 
            // lblPaidIn
            // 
            this.lblPaidIn.AutoSize = true;
            this.lblPaidIn.Location = new System.Drawing.Point(13, 56);
            this.lblPaidIn.Name = "lblPaidIn";
            this.lblPaidIn.Size = new System.Drawing.Size(52, 15);
            this.lblPaidIn.TabIndex = 2;
            this.lblPaidIn.Text = "Paid Ins ";
            // 
            // lblcashrevenu
            // 
            this.lblcashrevenu.AutoSize = true;
            this.lblcashrevenu.Location = new System.Drawing.Point(135, 27);
            this.lblcashrevenu.Name = "lblcashrevenu";
            this.lblcashrevenu.Size = new System.Drawing.Size(40, 15);
            this.lblcashrevenu.TabIndex = 1;
            this.lblcashrevenu.Text = "label5";
            // 
            // lblCashRev
            // 
            this.lblCashRev.AutoSize = true;
            this.lblCashRev.Location = new System.Drawing.Point(14, 27);
            this.lblCashRev.Name = "lblCashRev";
            this.lblCashRev.Size = new System.Drawing.Size(88, 15);
            this.lblCashRev.TabIndex = 0;
            this.lblCashRev.Text = "Cash Revenue ";
            // 
            // grpNCInfo
            // 
            this.grpNCInfo.Controls.Add(this.lbltotshort);
            this.grpNCInfo.Controls.Add(this.lbltotcashtry);
            this.grpNCInfo.Controls.Add(this.lblnetcash);
            this.grpNCInfo.Controls.Add(this.lblTCTray);
            this.grpNCInfo.Controls.Add(this.lblTotalShort);
            this.grpNCInfo.Controls.Add(this.lblNCChecks);
            this.grpNCInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpNCInfo.Location = new System.Drawing.Point(492, 199);
            this.grpNCInfo.Name = "grpNCInfo";
            this.grpNCInfo.Size = new System.Drawing.Size(201, 236);
            this.grpNCInfo.TabIndex = 3;
            this.grpNCInfo.TabStop = false;
            this.grpNCInfo.Text = "Non Cash Information";
            // 
            // lbltotshort
            // 
            this.lbltotshort.AutoSize = true;
            this.lbltotshort.Location = new System.Drawing.Point(117, 83);
            this.lbltotshort.Name = "lbltotshort";
            this.lbltotshort.Size = new System.Drawing.Size(0, 15);
            this.lbltotshort.TabIndex = 5;
            // 
            // lbltotcashtry
            // 
            this.lbltotcashtry.AutoSize = true;
            this.lbltotcashtry.Location = new System.Drawing.Point(117, 57);
            this.lbltotcashtry.Name = "lbltotcashtry";
            this.lbltotcashtry.Size = new System.Drawing.Size(0, 15);
            this.lbltotcashtry.TabIndex = 4;
            // 
            // lblnetcash
            // 
            this.lblnetcash.AutoSize = true;
            this.lblnetcash.Location = new System.Drawing.Point(117, 31);
            this.lblnetcash.Name = "lblnetcash";
            this.lblnetcash.Size = new System.Drawing.Size(0, 15);
            this.lblnetcash.TabIndex = 3;
            // 
            // lblTCTray
            // 
            this.lblTCTray.AutoSize = true;
            this.lblTCTray.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTCTray.Location = new System.Drawing.Point(6, 58);
            this.lblTCTray.Name = "lblTCTray";
            this.lblTCTray.Size = new System.Drawing.Size(117, 15);
            this.lblTCTray.TabIndex = 2;
            this.lblTCTray.Text = "Total Cash Tray        :";
            // 
            // lblTotalShort
            // 
            this.lblTotalShort.AutoSize = true;
            this.lblTotalShort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalShort.Location = new System.Drawing.Point(6, 84);
            this.lblTotalShort.Name = "lblTotalShort";
            this.lblTotalShort.Size = new System.Drawing.Size(117, 15);
            this.lblTotalShort.TabIndex = 1;
            this.lblTotalShort.Text = "Total Short               :";
            // 
            // lblNCChecks
            // 
            this.lblNCChecks.AutoSize = true;
            this.lblNCChecks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNCChecks.Location = new System.Drawing.Point(6, 31);
            this.lblNCChecks.Name = "lblNCChecks";
            this.lblNCChecks.Size = new System.Drawing.Size(118, 15);
            this.lblNCChecks.TabIndex = 0;
            this.lblNCChecks.Text = "Net Cash + Checks  :";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = global::GNetBillingSoft.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.Location = new System.Drawing.Point(612, 441);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 55);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTo);
            this.groupBox3.Controls.Add(this.dtTo);
            this.groupBox3.Controls.Add(this.lblFrom);
            this.groupBox3.Controls.Add(this.dtFrom);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(7, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(357, 63);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(179, 24);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 15);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(209, 19);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(102, 23);
            this.dtTo.TabIndex = 1;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            this.dtTo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.dtTo_PreviewKeyDown);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(8, 25);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 15);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(59, 19);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(102, 23);
            this.dtFrom.TabIndex = 0;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            this.dtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // frmcashtray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 499);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpNCInfo);
            this.Controls.Add(this.grpCashInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmcashtray";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Tray Report";
            this.Load += new System.EventHandler(this.frmcashtray_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdescription)).EndInit();
            this.grpCashInfo.ResumeLayout(false);
            this.grpCashInfo.PerformLayout();
            this.grpNCInfo.ResumeLayout(false);
            this.grpNCInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblEmploy;
        private System.Windows.Forms.Label lblDate1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvdescription;
        private System.Windows.Forms.GroupBox grpCashInfo;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblemployee;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblPaidOut;
        private System.Windows.Forms.Label lblLessTip;
        private System.Windows.Forms.Label lblCCTFee;
        private System.Windows.Forms.Label lblCashBack;
        private System.Windows.Forms.Label lblEmpPaidOut;
        private System.Windows.Forms.Label lblBCAmt;
        private System.Windows.Forms.Label lblGCDue;
        private System.Windows.Forms.Label lblMoneyDrop;
        private System.Windows.Forms.Label lblNetCashDue;
        private System.Windows.Forms.Label lblECADue;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblPaidIn;
        private System.Windows.Forms.Label lblcashrevenu;
        private System.Windows.Forms.Label lblCashRev;
        private System.Windows.Forms.TextBox txtshort;
        private System.Windows.Forms.TextBox txtcashamtdue;
        private System.Windows.Forms.TextBox txtgrosscash;
        private System.Windows.Forms.TextBox txtcashamount;
        private System.Windows.Forms.TextBox txtnetcashdue;
        private System.Windows.Forms.TextBox txtemppaidout;
        private System.Windows.Forms.TextBox txtmoneydrp;
        private System.Windows.Forms.TextBox txtcashback;
        private System.Windows.Forms.TextBox txtcreditcash;
        private System.Windows.Forms.TextBox txtlesstips;
        private System.Windows.Forms.TextBox txtpaidouts;
        private System.Windows.Forms.TextBox txtpaidins;
        private System.Windows.Forms.GroupBox grpNCInfo;
        private System.Windows.Forms.Label lbltotshort;
        private System.Windows.Forms.Label lbltotcashtry;
        private System.Windows.Forms.Label lblnetcash;
        private System.Windows.Forms.Label lblTCTray;
        private System.Windows.Forms.Label lblTotalShort;
        private System.Windows.Forms.Label lblNCChecks;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtFrom;
    }
}