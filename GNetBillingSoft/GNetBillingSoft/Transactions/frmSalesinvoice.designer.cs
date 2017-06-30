namespace GNetBillingSoft.Transactions
{
    partial class frmSalesinvoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesinvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.Label();
            this.txtinvoice = new System.Windows.Forms.DomainUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtopening = new System.Windows.Forms.TextBox();
            this.lblCOpening = new System.Windows.Forms.Label();
            this.txtcustomername = new System.Windows.Forms.ComboBox();
            this.txtphoneno = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdiscamount = new System.Windows.Forms.TextBox();
            this.txtadddiscount = new System.Windows.Forms.TextBox();
            this.lblAdDiscount = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txttotalitem = new System.Windows.Forms.TextBox();
            this.lblTotItem = new System.Windows.Forms.Label();
            this.txtnetamt = new System.Windows.Forms.TextBox();
            this.lblNetAmt = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.txttotalpaid = new System.Windows.Forms.TextBox();
            this.lblTotPaid = new System.Windows.Forms.Label();
            this.txtpaidcheque = new System.Windows.Forms.TextBox();
            this.lblPaidCheq = new System.Windows.Forms.Label();
            this.txtpaidcash = new System.Windows.Forms.TextBox();
            this.lblPaidCash = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnmainclose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorSalesinvoice = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdsales = new System.Windows.Forms.DataGridView();
            this.itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalesinvoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdsales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddr
            // 
            this.lblAddr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAddr.Location = new System.Drawing.Point(342, 79);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(57, 17);
            this.lblAddr.TabIndex = 5;
            this.lblAddr.Text = "Address";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCustName.Location = new System.Drawing.Point(10, 81);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(107, 17);
            this.lblCustName.TabIndex = 6;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(748, 103);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 17);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.AutoSize = true;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtdate.Location = new System.Drawing.Point(867, 28);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(36, 19);
            this.txtdate.TabIndex = 17;
            this.txtdate.Text = "date";
            // 
            // txtinvoice
            // 
            this.txtinvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.Location = new System.Drawing.Point(146, 24);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(153, 23);
            this.txtinvoice.TabIndex = 1;
            this.txtinvoice.SelectedItemChanged += new System.EventHandler(this.txtinvoice_SelectedItemChanged);
            this.txtinvoice.TextChanged += new System.EventHandler(this.txtinvoice_TextChanged);
            this.txtinvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtinvoice_KeyDown);
            this.txtinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvoice_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(811, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 19);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVoucherNo.Location = new System.Drawing.Point(12, 28);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(81, 17);
            this.lblVoucherNo.TabIndex = 11;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.txtopening);
            this.groupBox2.Controls.Add(this.txtinvoice);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.lblCOpening);
            this.groupBox2.Controls.Add(this.lblVoucherNo);
            this.groupBox2.Controls.Add(this.txtcustomername);
            this.groupBox2.Controls.Add(this.txtphoneno);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.lblCustName);
            this.groupBox2.Controls.Add(this.lblAddr);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtopening
            // 
            this.txtopening.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopening.Location = new System.Drawing.Point(146, 119);
            this.txtopening.Name = "txtopening";
            this.txtopening.Size = new System.Drawing.Size(153, 23);
            this.txtopening.TabIndex = 4;
            this.txtopening.Text = "0.0";
            this.txtopening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblCOpening
            // 
            this.lblCOpening.AutoSize = true;
            this.lblCOpening.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCOpening.Location = new System.Drawing.Point(12, 121);
            this.lblCOpening.Name = "lblCOpening";
            this.lblCOpening.Size = new System.Drawing.Size(124, 17);
            this.lblCOpening.TabIndex = 8;
            this.lblCOpening.Text = "Customer Opening";
            // 
            // txtcustomername
            // 
            this.txtcustomername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcustomername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.FormattingEnabled = true;
            this.txtcustomername.Location = new System.Drawing.Point(146, 76);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(153, 23);
            this.txtcustomername.TabIndex = 3;
            this.txtcustomername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtcustomername.Leave += new System.EventHandler(this.txtcustomername_Leave);
            // 
            // txtphoneno
            // 
            this.txtphoneno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphoneno.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.txtphoneno.Location = new System.Drawing.Point(749, 121);
            this.txtphoneno.Mask = "00000000000000";
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(158, 22);
            this.txtphoneno.TabIndex = 6;
            this.txtphoneno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(399, 76);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(230, 66);
            this.txtaddress.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtdiscamount);
            this.groupBox3.Controls.Add(this.txtadddiscount);
            this.groupBox3.Controls.Add(this.lblAdDiscount);
            this.groupBox3.Controls.Add(this.txtdiscount);
            this.groupBox3.Controls.Add(this.lblDiscount);
            this.groupBox3.Controls.Add(this.txttotalitem);
            this.groupBox3.Controls.Add(this.lblTotItem);
            this.groupBox3.Location = new System.Drawing.Point(7, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 55);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // txtdiscamount
            // 
            this.txtdiscamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtdiscamount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscamount.Location = new System.Drawing.Point(405, 19);
            this.txtdiscamount.Name = "txtdiscamount";
            this.txtdiscamount.Size = new System.Drawing.Size(67, 23);
            this.txtdiscamount.TabIndex = 10;
            this.txtdiscamount.TextChanged += new System.EventHandler(this.txtdiscamount_TextChanged);
            this.txtdiscamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscamount_KeyDown);
            this.txtdiscamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscamount_KeyPress);
            // 
            // txtadddiscount
            // 
            this.txtadddiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtadddiscount.BackColor = System.Drawing.Color.White;
            this.txtadddiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadddiscount.Location = new System.Drawing.Point(629, 19);
            this.txtadddiscount.Name = "txtadddiscount";
            this.txtadddiscount.Size = new System.Drawing.Size(79, 23);
            this.txtadddiscount.TabIndex = 11;
            this.txtadddiscount.TextChanged += new System.EventHandler(this.txtadddiscount_TextChanged);
            this.txtadddiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblAdDiscount
            // 
            this.lblAdDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAdDiscount.AutoSize = true;
            this.lblAdDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAdDiscount.Location = new System.Drawing.Point(529, 22);
            this.lblAdDiscount.Name = "lblAdDiscount";
            this.lblAdDiscount.Size = new System.Drawing.Size(92, 17);
            this.lblAdDiscount.TabIndex = 18;
            this.lblAdDiscount.Text = "Add.Discount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtdiscount.BackColor = System.Drawing.Color.White;
            this.txtdiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(361, 19);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(41, 23);
            this.txtdiscount.TabIndex = 9;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiscount_KeyDown);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(281, 21);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(78, 17);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Discount %";
            // 
            // txttotalitem
            // 
            this.txttotalitem.BackColor = System.Drawing.Color.White;
            this.txttotalitem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalitem.Location = new System.Drawing.Point(117, 19);
            this.txttotalitem.Name = "txttotalitem";
            this.txttotalitem.ReadOnly = true;
            this.txttotalitem.Size = new System.Drawing.Size(102, 23);
            this.txttotalitem.TabIndex = 8;
            // 
            // lblTotItem
            // 
            this.lblTotItem.AutoSize = true;
            this.lblTotItem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotItem.Location = new System.Drawing.Point(6, 22);
            this.lblTotItem.Name = "lblTotItem";
            this.lblTotItem.Size = new System.Drawing.Size(72, 17);
            this.lblTotItem.TabIndex = 12;
            this.lblTotItem.Text = "Total Item";
            // 
            // txtnetamt
            // 
            this.txtnetamt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnetamt.BackColor = System.Drawing.Color.White;
            this.txtnetamt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Location = new System.Drawing.Point(112, 15);
            this.txtnetamt.Name = "txtnetamt";
            this.txtnetamt.ReadOnly = true;
            this.txtnetamt.Size = new System.Drawing.Size(112, 23);
            this.txtnetamt.TabIndex = 12;
            this.txtnetamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnetamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblNetAmt
            // 
            this.lblNetAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetAmt.AutoSize = true;
            this.lblNetAmt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNetAmt.Location = new System.Drawing.Point(7, 19);
            this.lblNetAmt.Name = "lblNetAmt";
            this.lblNetAmt.Size = new System.Drawing.Size(84, 17);
            this.lblNetAmt.TabIndex = 16;
            this.lblNetAmt.Text = "Net Amount";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtbalance);
            this.groupBox4.Controls.Add(this.lblBal);
            this.groupBox4.Controls.Add(this.txttotalpaid);
            this.groupBox4.Controls.Add(this.txtnetamt);
            this.groupBox4.Controls.Add(this.lblTotPaid);
            this.groupBox4.Controls.Add(this.lblNetAmt);
            this.groupBox4.Controls.Add(this.txtpaidcheque);
            this.groupBox4.Controls.Add(this.lblPaidCheq);
            this.groupBox4.Controls.Add(this.txtpaidcash);
            this.groupBox4.Controls.Add(this.lblPaidCash);
            this.groupBox4.Location = new System.Drawing.Point(738, 378);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 190);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 2);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(114, 156);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(112, 25);
            this.txtbalance.TabIndex = 16;
            this.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBal.ForeColor = System.Drawing.Color.Red;
            this.lblBal.Location = new System.Drawing.Point(8, 160);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(55, 17);
            this.lblBal.TabIndex = 22;
            this.lblBal.Text = "Balance";
            // 
            // txttotalpaid
            // 
            this.txttotalpaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpaid.Location = new System.Drawing.Point(114, 123);
            this.txttotalpaid.Name = "txttotalpaid";
            this.txttotalpaid.Size = new System.Drawing.Size(112, 25);
            this.txttotalpaid.TabIndex = 15;
            this.txttotalpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotalpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblTotPaid
            // 
            this.lblTotPaid.AutoSize = true;
            this.lblTotPaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotPaid.ForeColor = System.Drawing.Color.Blue;
            this.lblTotPaid.Location = new System.Drawing.Point(8, 130);
            this.lblTotPaid.Name = "lblTotPaid";
            this.lblTotPaid.Size = new System.Drawing.Size(71, 17);
            this.lblTotPaid.TabIndex = 20;
            this.lblTotPaid.Text = "Total Paid";
            // 
            // txtpaidcheque
            // 
            this.txtpaidcheque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidcheque.Location = new System.Drawing.Point(114, 90);
            this.txtpaidcheque.Name = "txtpaidcheque";
            this.txtpaidcheque.Size = new System.Drawing.Size(112, 25);
            this.txtpaidcheque.TabIndex = 14;
            this.txtpaidcheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpaidcheque.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            this.txtpaidcheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblPaidCheq
            // 
            this.lblPaidCheq.AutoSize = true;
            this.lblPaidCheq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPaidCheq.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPaidCheq.Location = new System.Drawing.Point(8, 95);
            this.lblPaidCheq.Name = "lblPaidCheq";
            this.lblPaidCheq.Size = new System.Drawing.Size(85, 17);
            this.lblPaidCheq.TabIndex = 18;
            this.lblPaidCheq.Text = "Paid Cheque";
            // 
            // txtpaidcash
            // 
            this.txtpaidcash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidcash.Location = new System.Drawing.Point(114, 57);
            this.txtpaidcash.Name = "txtpaidcash";
            this.txtpaidcash.Size = new System.Drawing.Size(112, 25);
            this.txtpaidcash.TabIndex = 13;
            this.txtpaidcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpaidcash.TextChanged += new System.EventHandler(this.txtpaidcash_TextChanged);
            this.txtpaidcash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtpaidcash.Leave += new System.EventHandler(this.txtpaidcash_Leave);
            // 
            // lblPaidCash
            // 
            this.lblPaidCash.AutoSize = true;
            this.lblPaidCash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPaidCash.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPaidCash.Location = new System.Drawing.Point(7, 62);
            this.lblPaidCash.Name = "lblPaidCash";
            this.lblPaidCash.Size = new System.Drawing.Size(68, 17);
            this.lblPaidCash.TabIndex = 16;
            this.lblPaidCash.Text = "Paid Cash";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImage = global::GNetBillingSoft.Properties.Resources.eraser_icon;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(560, 503);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 61);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkPrint
            // 
            this.chkPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrint.AutoSize = true;
            this.chkPrint.BackColor = System.Drawing.Color.Transparent;
            this.chkPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.chkPrint.Location = new System.Drawing.Point(201, 478);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(119, 19);
            this.chkPrint.TabIndex = 25;
            this.chkPrint.Text = "Print while saving";
            this.chkPrint.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprint.BackColor = System.Drawing.Color.White;
            this.btnprint.BackgroundImage = global::GNetBillingSoft.Properties.Resources.printer;
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(471, 503);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 61);
            this.btnprint.TabIndex = 20;
            this.btnprint.Text = "Print";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnmainclose
            // 
            this.btnmainclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmainclose.BackColor = System.Drawing.Color.White;
            this.btnmainclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmainclose.BackgroundImage")));
            this.btnmainclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmainclose.FlatAppearance.BorderSize = 0;
            this.btnmainclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmainclose.Location = new System.Drawing.Point(649, 503);
            this.btnmainclose.Name = "btnmainclose";
            this.btnmainclose.Size = new System.Drawing.Size(75, 61);
            this.btnmainclose.TabIndex = 22;
            this.btnmainclose.Text = "Close";
            this.btnmainclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmainclose.UseVisualStyleBackColor = false;
            this.btnmainclose.Click += new System.EventHandler(this.btnmainclose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(381, 503);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 61);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnedit.BackgroundImage")));
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(291, 503);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 61);
            this.btnedit.TabIndex = 18;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(201, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 61);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorSalesinvoice
            // 
            this.errorSalesinvoice.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grdsales);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.6F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 210);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // grdsales
            // 
            this.grdsales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdsales.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemno,
            this.description,
            this.unit,
            this.quantity,
            this.price,
            this.total,
            this.netamount,
            this.stock,
            this.newcost});
            this.grdsales.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grdsales.Location = new System.Drawing.Point(6, 19);
            this.grdsales.Name = "grdsales";
            this.grdsales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdsales.Size = new System.Drawing.Size(964, 185);
            this.grdsales.TabIndex = 7;
            this.grdsales.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdsales_CellBeginEdit);
            this.grdsales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdsales_CellClick);
            this.grdsales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdsales_CellValueChanged);
            this.grdsales.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdsales_EditingControlShowing);
            this.grdsales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdsales_KeyDown_1);
            // 
            // itemno
            // 
            this.itemno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemno.HeaderText = "Item No";
            this.itemno.Name = "itemno";
            this.itemno.Width = 80;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.description.DefaultCellStyle = dataGridViewCellStyle1;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 250;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unit.HeaderText = "Unit";
            this.unit.Items.AddRange(new object[] {
            "psc"});
            this.unit.Name = "unit";
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle4;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // netamount
            // 
            this.netamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.netamount.DefaultCellStyle = dataGridViewCellStyle5;
            this.netamount.HeaderText = "Net.Amt";
            this.netamount.Name = "netamount";
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // newcost
            // 
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.newcost.DefaultCellStyle = dataGridViewCellStyle6;
            this.newcost.HeaderText = "Current Cost";
            this.newcost.Name = "newcost";
            // 
            // frmSalesinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::GNetBillingSoft.Properties.Resources.WhatsApp_Image_2017_06_23_at_11_27_35_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 574);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnmainclose);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmSalesinvoice";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Sales Invoice";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSalesinvoice_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalesinvoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdsales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtnetamt;
        private System.Windows.Forms.Label lblNetAmt;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txttotalitem;
        private System.Windows.Forms.Label lblTotItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.TextBox txttotalpaid;
        private System.Windows.Forms.Label lblTotPaid;
        private System.Windows.Forms.TextBox txtpaidcheque;
        private System.Windows.Forms.Label lblPaidCheq;
        private System.Windows.Forms.TextBox txtpaidcash;
        private System.Windows.Forms.Label lblPaidCash;
        private System.Windows.Forms.TextBox txtadddiscount;
        private System.Windows.Forms.Label lblAdDiscount;
        private System.Windows.Forms.DomainUpDown txtinvoice;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Button btnmainclose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorSalesinvoice;
        private System.Windows.Forms.MaskedTextBox txtphoneno;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox txtcustomername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdsales;
        private System.Windows.Forms.TextBox txtdiscamount;
        private System.Windows.Forms.Label lblCOpening;
        private System.Windows.Forms.TextBox txtopening;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemno;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewComboBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn netamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn newcost;
    }
}

