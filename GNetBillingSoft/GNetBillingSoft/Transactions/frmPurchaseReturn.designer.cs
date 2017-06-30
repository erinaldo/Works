namespace GNetBillingSoft.Transactions
{
    partial class frmPurchaseReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtinvoice = new System.Windows.Forms.DomainUpDown();
            this.txtdate = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtoldinvoice = new System.Windows.Forms.TextBox();
            this.lblOldInv = new System.Windows.Forms.Label();
            this.txtphonenumber = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.lblsuppliename = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnetamount = new System.Windows.Forms.TextBox();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txttotitem = new System.Windows.Forms.TextBox();
            this.lblTotItem = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpaidcash = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.lblTotPaid = new System.Windows.Forms.Label();
            this.txtpaidcheque = new System.Windows.Forms.TextBox();
            this.lblPaidCheq = new System.Windows.Forms.Label();
            this.lblPaidCash = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAdDiscount = new System.Windows.Forms.Label();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            this.SuspendLayout();
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantity.FillWeight = 36.08248F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle2;
            this.total.FillWeight = 36.08248F;
            this.total.HeaderText = "Tota";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // netamount
            // 
            this.netamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.netamount.DefaultCellStyle = dataGridViewCellStyle3;
            this.netamount.FillWeight = 36.08248F;
            this.netamount.HeaderText = "Net.Amt";
            this.netamount.Name = "netamount";
            this.netamount.ReadOnly = true;
            // 
            // oldcost
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.oldcost.DefaultCellStyle = dataGridViewCellStyle4;
            this.oldcost.HeaderText = "Old Cost";
            this.oldcost.Name = "oldcost";
            this.oldcost.ReadOnly = true;
            // 
            // purchaseid
            // 
            this.purchaseid.HeaderText = "purchaseid";
            this.purchaseid.Name = "purchaseid";
            this.purchaseid.Visible = false;
            // 
            // txtinvoice
            // 
            this.txtinvoice.Location = new System.Drawing.Point(115, 21);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(153, 20);
            this.txtinvoice.TabIndex = 1;
            this.txtinvoice.TextChanged += new System.EventHandler(this.txtinvoice_TextChanged);
            this.txtinvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtinvoice_KeyDown);
            this.txtinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvoice_KeyPress);
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.AutoSize = true;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtdate.Location = new System.Drawing.Point(746, 24);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(38, 19);
            this.txtdate.TabIndex = 15;
            this.txtdate.Text = "Date";
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbldate.Location = new System.Drawing.Point(703, 24);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(38, 19);
            this.lbldate.TabIndex = 13;
            this.lbldate.Text = "Date";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVoucherNo.Location = new System.Drawing.Point(15, 24);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(81, 17);
            this.lblVoucherNo.TabIndex = 11;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtinvoice);
            this.groupBox2.Controls.Add(this.txtdate);
            this.groupBox2.Controls.Add(this.lbldate);
            this.groupBox2.Controls.Add(this.lblVoucherNo);
            this.groupBox2.Controls.Add(this.txtoldinvoice);
            this.groupBox2.Controls.Add(this.lblOldInv);
            this.groupBox2.Controls.Add(this.txtphonenumber);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtsupplier);
            this.groupBox2.Controls.Add(this.lblsuppliename);
            this.groupBox2.Controls.Add(this.lblphonenumber);
            this.groupBox2.Controls.Add(this.lbladdress);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtoldinvoice
            // 
            this.txtoldinvoice.Location = new System.Drawing.Point(115, 68);
            this.txtoldinvoice.Name = "txtoldinvoice";
            this.txtoldinvoice.Size = new System.Drawing.Size(153, 20);
            this.txtoldinvoice.TabIndex = 2;
            this.txtoldinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblOldInv
            // 
            this.lblOldInv.AutoSize = true;
            this.lblOldInv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOldInv.Location = new System.Drawing.Point(15, 70);
            this.lblOldInv.Name = "lblOldInv";
            this.lblOldInv.Size = new System.Drawing.Size(82, 17);
            this.lblOldInv.TabIndex = 15;
            this.lblOldInv.Text = "Old Invoice ";
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtphonenumber.Location = new System.Drawing.Point(658, 109);
            this.txtphonenumber.Mask = "00000000000000";
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(153, 20);
            this.txtphonenumber.TabIndex = 5;
            this.txtphonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaddress.Location = new System.Drawing.Point(368, 68);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(257, 64);
            this.txtaddress.TabIndex = 4;
            // 
            // txtsupplier
            // 
            this.txtsupplier.Location = new System.Drawing.Point(115, 113);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(153, 20);
            this.txtsupplier.TabIndex = 3;
            this.txtsupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblsuppliename
            // 
            this.lblsuppliename.AutoSize = true;
            this.lblsuppliename.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblsuppliename.Location = new System.Drawing.Point(15, 114);
            this.lblsuppliename.Name = "lblsuppliename";
            this.lblsuppliename.Size = new System.Drawing.Size(91, 17);
            this.lblsuppliename.TabIndex = 12;
            this.lblsuppliename.Text = "Suplier Name";
            this.lblsuppliename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblphonenumber.Location = new System.Drawing.Point(655, 91);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(101, 17);
            this.lblphonenumber.TabIndex = 7;
            this.lblphonenumber.Text = "Phone Number";
            // 
            // lbladdress
            // 
            this.lbladdress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbladdress.Location = new System.Drawing.Point(305, 70);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(57, 17);
            this.lbladdress.TabIndex = 5;
            this.lbladdress.Text = "Address";
            // 
            // chkPrint
            // 
            this.chkPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrint.AutoSize = true;
            this.chkPrint.BackColor = System.Drawing.Color.Transparent;
            this.chkPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrint.Location = new System.Drawing.Point(24, 448);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(122, 21);
            this.chkPrint.TabIndex = 20;
            this.chkPrint.Text = "Print while save";
            this.chkPrint.UseVisualStyleBackColor = false;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "Price";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle5;
            this.price.FillWeight = 36.08248F;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.FillWeight = 36.08248F;
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // txtnetamount
            // 
            this.txtnetamount.BackColor = System.Drawing.Color.White;
            this.txtnetamount.Location = new System.Drawing.Point(137, 15);
            this.txtnetamount.Name = "txtnetamount";
            this.txtnetamount.ReadOnly = true;
            this.txtnetamount.Size = new System.Drawing.Size(103, 20);
            this.txtnetamount.TabIndex = 10;
            this.txtnetamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNetTotal.Location = new System.Drawing.Point(13, 18);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(66, 17);
            this.lblNetTotal.TabIndex = 16;
            this.lblNetTotal.Text = "Net Total";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdiscount.BackColor = System.Drawing.Color.White;
            this.txtdiscount.Location = new System.Drawing.Point(308, 22);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(68, 20);
            this.txtdiscount.TabIndex = 8;
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(227, 23);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(78, 17);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Discount %";
            // 
            // txttotitem
            // 
            this.txttotitem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttotitem.BackColor = System.Drawing.Color.White;
            this.txttotitem.Location = new System.Drawing.Point(120, 23);
            this.txttotitem.Name = "txttotitem";
            this.txttotitem.ReadOnly = true;
            this.txttotitem.Size = new System.Drawing.Size(71, 20);
            this.txttotitem.TabIndex = 7;
            this.txttotitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblTotItem
            // 
            this.lblTotItem.AutoSize = true;
            this.lblTotItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotItem.Location = new System.Drawing.Point(12, 25);
            this.lblTotItem.Name = "lblTotItem";
            this.lblTotItem.Size = new System.Drawing.Size(72, 17);
            this.lblTotItem.TabIndex = 12;
            this.lblTotItem.Text = "Total Item";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txtnetamount);
            this.groupBox4.Controls.Add(this.lblNetTotal);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtpaidcash);
            this.groupBox4.Controls.Add(this.txtBalance);
            this.groupBox4.Controls.Add(this.lblBal);
            this.groupBox4.Controls.Add(this.txtpaid);
            this.groupBox4.Controls.Add(this.lblTotPaid);
            this.groupBox4.Controls.Add(this.txtpaidcheque);
            this.groupBox4.Controls.Add(this.lblPaidCheq);
            this.groupBox4.Controls.Add(this.lblPaidCash);
            this.groupBox4.Location = new System.Drawing.Point(606, 358);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 174);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 2);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            // 
            // txtpaidcash
            // 
            this.txtpaidcash.Location = new System.Drawing.Point(137, 56);
            this.txtpaidcash.Name = "txtpaidcash";
            this.txtpaidcash.Size = new System.Drawing.Size(103, 20);
            this.txtpaidcash.TabIndex = 11;
            this.txtpaidcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBalance.Location = new System.Drawing.Point(137, 146);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(103, 20);
            this.txtBalance.TabIndex = 14;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBal.Location = new System.Drawing.Point(11, 147);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(55, 17);
            this.lblBal.TabIndex = 22;
            this.lblBal.Text = "Balance";
            // 
            // txtpaid
            // 
            this.txtpaid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpaid.Location = new System.Drawing.Point(137, 117);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.ReadOnly = true;
            this.txtpaid.Size = new System.Drawing.Size(103, 20);
            this.txtpaid.TabIndex = 13;
            this.txtpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotPaid
            // 
            this.lblTotPaid.AutoSize = true;
            this.lblTotPaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotPaid.ForeColor = System.Drawing.Color.Green;
            this.lblTotPaid.Location = new System.Drawing.Point(11, 118);
            this.lblTotPaid.Name = "lblTotPaid";
            this.lblTotPaid.Size = new System.Drawing.Size(71, 17);
            this.lblTotPaid.TabIndex = 20;
            this.lblTotPaid.Text = "Total Paid";
            // 
            // txtpaidcheque
            // 
            this.txtpaidcheque.Location = new System.Drawing.Point(137, 86);
            this.txtpaidcheque.Name = "txtpaidcheque";
            this.txtpaidcheque.Size = new System.Drawing.Size(103, 20);
            this.txtpaidcheque.TabIndex = 12;
            this.txtpaidcheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPaidCheq
            // 
            this.lblPaidCheq.AutoSize = true;
            this.lblPaidCheq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPaidCheq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPaidCheq.Location = new System.Drawing.Point(11, 89);
            this.lblPaidCheq.Name = "lblPaidCheq";
            this.lblPaidCheq.Size = new System.Drawing.Size(85, 17);
            this.lblPaidCheq.TabIndex = 18;
            this.lblPaidCheq.Text = "Paid Cheque";
            // 
            // lblPaidCash
            // 
            this.lblPaidCash.AutoSize = true;
            this.lblPaidCash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPaidCash.Location = new System.Drawing.Point(11, 57);
            this.lblPaidCash.Name = "lblPaidCash";
            this.lblPaidCash.Size = new System.Drawing.Size(68, 17);
            this.lblPaidCash.TabIndex = 16;
            this.lblPaidCash.Text = "Paid Cash";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.lblAdDiscount);
            this.groupBox3.Controls.Add(this.txtdiscount);
            this.groupBox3.Controls.Add(this.lblDiscount);
            this.groupBox3.Controls.Add(this.txttotitem);
            this.groupBox3.Controls.Add(this.lblTotItem);
            this.groupBox3.Location = new System.Drawing.Point(8, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 62);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(494, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblAdDiscount
            // 
            this.lblAdDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAdDiscount.AutoSize = true;
            this.lblAdDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAdDiscount.Location = new System.Drawing.Point(401, 25);
            this.lblAdDiscount.Name = "lblAdDiscount";
            this.lblAdDiscount.Size = new System.Drawing.Size(92, 17);
            this.lblAdDiscount.TabIndex = 15;
            this.lblAdDiscount.Text = "Add.Discount";
            // 
            // grdItems
            // 
            this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItems.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemno,
            this.description,
            this.unit,
            this.quantity,
            this.price,
            this.total,
            this.netamount,
            this.oldcost,
            this.purchaseid});
            this.grdItems.Location = new System.Drawing.Point(4, 174);
            this.grdItems.Name = "grdItems";
            this.grdItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdItems.Size = new System.Drawing.Size(855, 170);
            this.grdItems.TabIndex = 6;
            this.grdItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdItems_CellBeginEdit);
            this.grdItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellEndEdit);
            this.grdItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellValueChanged);
            // 
            // itemno
            // 
            this.itemno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemno.DataPropertyName = "itemid";
            this.itemno.FillWeight = 36.08248F;
            this.itemno.HeaderText = "Item No";
            this.itemno.Name = "itemno";
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.description.DataPropertyName = "Description";
            this.description.FillWeight = 483.5051F;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 250;
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.BackgroundImage = global::GNetBillingSoft.Properties.Resources.eraser_icon;
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(425, 473);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 59);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "Clear";
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclear.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::GNetBillingSoft.Properties.Resources.red_cross_icon_215331;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(516, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 59);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = global::GNetBillingSoft.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(334, 473);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 59);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::GNetBillingSoft.Properties.Resources.delete_xxl;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(232, 473);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 59);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = global::GNetBillingSoft.Properties.Resources.Save_icon;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(24, 475);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 57);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.BackgroundImage = global::GNetBillingSoft.Properties.Resources.edit_notes_icons_21;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnedit.Location = new System.Drawing.Point(129, 473);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(88, 59);
            this.btnedit.TabIndex = 18;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // frmPurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::GNetBillingSoft.Properties.Resources.formBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 544);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grdItems);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnedit);
            this.DoubleBuffered = true;
            this.Name = "frmPurchaseReturn";
            this.Text = "Purchase Return";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn netamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseid;
        private System.Windows.Forms.DomainUpDown txtinvoice;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.Label lblsuppliename;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtpaidcash;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.Label lblTotPaid;
        private System.Windows.Forms.TextBox txtpaidcheque;
        private System.Windows.Forms.Label lblPaidCheq;
        private System.Windows.Forms.Label lblPaidCash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtnetamount;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txttotitem;
        private System.Windows.Forms.Label lblTotItem;
        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemno;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.TextBox txtoldinvoice;
        private System.Windows.Forms.Label lblOldInv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdDiscount;
        private System.Windows.Forms.TextBox textBox1;
    }
}