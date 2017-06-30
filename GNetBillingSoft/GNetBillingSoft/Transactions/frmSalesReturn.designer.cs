namespace GNetBillingSoft.Transactions
{
    partial class frmSalesReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesReturn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lblBal = new System.Windows.Forms.Label();
            this.txtnetamt = new System.Windows.Forms.TextBox();
            this.lblNetAmnt = new System.Windows.Forms.Label();
            this.txttotalpaid = new System.Windows.Forms.TextBox();
            this.lblTotPaid = new System.Windows.Forms.Label();
            this.txtpaidcash = new System.Windows.Forms.TextBox();
            this.lblPaidCash = new System.Windows.Forms.Label();
            this.txtadddiscount = new System.Windows.Forms.TextBox();
            this.lblAdDiscount = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnmainclose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorSalesinvoice = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txttotalitem = new System.Windows.Forms.TextBox();
            this.lblTotItem = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcustomername = new System.Windows.Forms.ComboBox();
            this.txtphoneno = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.Label();
            this.txtinvoice = new System.Windows.Forms.DomainUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.grdsales = new System.Windows.Forms.DataGridView();
            this.itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scode_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalesinvoice)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdsales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtbalance);
            this.groupBox4.Controls.Add(this.lblBal);
            this.groupBox4.Controls.Add(this.txtnetamt);
            this.groupBox4.Controls.Add(this.lblNetAmnt);
            this.groupBox4.Controls.Add(this.txttotalpaid);
            this.groupBox4.Controls.Add(this.lblTotPaid);
            this.groupBox4.Controls.Add(this.txtpaidcash);
            this.groupBox4.Controls.Add(this.lblPaidCash);
            this.groupBox4.Location = new System.Drawing.Point(726, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 184);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 2);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(131, 146);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(125, 21);
            this.txtbalance.TabIndex = 11;
            this.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBal.Location = new System.Drawing.Point(10, 149);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(61, 19);
            this.lblBal.TabIndex = 22;
            this.lblBal.Text = "Balance";
            // 
            // txtnetamt
            // 
            this.txtnetamt.BackColor = System.Drawing.Color.White;
            this.txtnetamt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamt.Location = new System.Drawing.Point(131, 15);
            this.txtnetamt.Name = "txtnetamt";
            this.txtnetamt.ReadOnly = true;
            this.txtnetamt.Size = new System.Drawing.Size(125, 23);
            this.txtnetamt.TabIndex = 8;
            this.txtnetamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnetamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblNetAmnt
            // 
            this.lblNetAmnt.AutoSize = true;
            this.lblNetAmnt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNetAmnt.Location = new System.Drawing.Point(11, 19);
            this.lblNetAmnt.Name = "lblNetAmnt";
            this.lblNetAmnt.Size = new System.Drawing.Size(90, 19);
            this.lblNetAmnt.TabIndex = 16;
            this.lblNetAmnt.Text = "Net Amount";
            // 
            // txttotalpaid
            // 
            this.txttotalpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpaid.Location = new System.Drawing.Point(131, 110);
            this.txttotalpaid.Name = "txttotalpaid";
            this.txttotalpaid.Size = new System.Drawing.Size(125, 21);
            this.txttotalpaid.TabIndex = 10;
            this.txttotalpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txttotalpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblTotPaid
            // 
            this.lblTotPaid.AutoSize = true;
            this.lblTotPaid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotPaid.ForeColor = System.Drawing.Color.Navy;
            this.lblTotPaid.Location = new System.Drawing.Point(10, 112);
            this.lblTotPaid.Name = "lblTotPaid";
            this.lblTotPaid.Size = new System.Drawing.Size(77, 19);
            this.lblTotPaid.TabIndex = 20;
            this.lblTotPaid.Text = "Total Paid";
            // 
            // txtpaidcash
            // 
            this.txtpaidcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidcash.Location = new System.Drawing.Point(131, 75);
            this.txtpaidcash.Name = "txtpaidcash";
            this.txtpaidcash.Size = new System.Drawing.Size(125, 21);
            this.txtpaidcash.TabIndex = 9;
            this.txtpaidcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpaidcash.TextChanged += new System.EventHandler(this.txtpaidcash_Leave);
            this.txtpaidcash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblPaidCash
            // 
            this.lblPaidCash.AutoSize = true;
            this.lblPaidCash.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaidCash.ForeColor = System.Drawing.Color.Green;
            this.lblPaidCash.Location = new System.Drawing.Point(10, 75);
            this.lblPaidCash.Name = "lblPaidCash";
            this.lblPaidCash.Size = new System.Drawing.Size(74, 19);
            this.lblPaidCash.TabIndex = 16;
            this.lblPaidCash.Text = "Paid Cash";
            // 
            // txtadddiscount
            // 
            this.txtadddiscount.BackColor = System.Drawing.Color.White;
            this.txtadddiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadddiscount.Location = new System.Drawing.Point(610, 17);
            this.txtadddiscount.Name = "txtadddiscount";
            this.txtadddiscount.ReadOnly = true;
            this.txtadddiscount.Size = new System.Drawing.Size(89, 23);
            this.txtadddiscount.TabIndex = 7;
            this.txtadddiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblAdDiscount
            // 
            this.lblAdDiscount.AutoSize = true;
            this.lblAdDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdDiscount.Location = new System.Drawing.Point(513, 20);
            this.lblAdDiscount.Name = "lblAdDiscount";
            this.lblAdDiscount.Size = new System.Drawing.Size(93, 17);
            this.lblAdDiscount.TabIndex = 18;
            this.lblAdDiscount.Text = "Add. Discount";
            // 
            // txtdiscount
            // 
            this.txtdiscount.BackColor = System.Drawing.Color.White;
            this.txtdiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(337, 18);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(76, 23);
            this.txtdiscount.TabIndex = 6;
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.chkPrint);
            this.groupBox5.Controls.Add(this.btnprint);
            this.groupBox5.Controls.Add(this.btnmainclose);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnedit);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(166, 423);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(554, 102);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImage = global::GNetBillingSoft.Properties.Resources.eraser_icon;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(369, 35);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 61);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrint.Location = new System.Drawing.Point(19, 12);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(127, 21);
            this.chkPrint.TabIndex = 25;
            this.chkPrint.Text = "Print while saving";
            this.chkPrint.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.White;
            this.btnprint.BackgroundImage = global::GNetBillingSoft.Properties.Resources.printer;
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnprint.FlatAppearance.BorderSize = 0;
            this.btnprint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(282, 35);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 61);
            this.btnprint.TabIndex = 14;
            this.btnprint.Text = "Print";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnmainclose
            // 
            this.btnmainclose.BackColor = System.Drawing.Color.White;
            this.btnmainclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmainclose.BackgroundImage")));
            this.btnmainclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmainclose.FlatAppearance.BorderSize = 0;
            this.btnmainclose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmainclose.Location = new System.Drawing.Point(457, 35);
            this.btnmainclose.Name = "btnmainclose";
            this.btnmainclose.Size = new System.Drawing.Size(75, 61);
            this.btnmainclose.TabIndex = 13;
            this.btnmainclose.Text = "Close";
            this.btnmainclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmainclose.UseVisualStyleBackColor = false;
            this.btnmainclose.Click += new System.EventHandler(this.btnmainclose_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(193, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 61);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnedit.BackgroundImage")));
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(105, 35);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 61);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(17, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 61);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorSalesinvoice
            // 
            this.errorSalesinvoice.ContainerControl = this;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(264, 20);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(76, 17);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Discount %";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblCustName.Location = new System.Drawing.Point(15, 40);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(107, 17);
            this.lblCustName.TabIndex = 6;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblAddr
            // 
            this.lblAddr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAddr.Location = new System.Drawing.Point(695, 16);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(57, 17);
            this.lblAddr.TabIndex = 5;
            this.lblAddr.Text = "Address";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.txtadddiscount);
            this.groupBox.Controls.Add(this.lblAdDiscount);
            this.groupBox.Controls.Add(this.txtdiscount);
            this.groupBox.Controls.Add(this.lblDiscount);
            this.groupBox.Controls.Add(this.txttotalitem);
            this.groupBox.Controls.Add(this.lblTotItem);
            this.groupBox.Location = new System.Drawing.Point(6, 349);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(714, 50);
            this.groupBox.TabIndex = 28;
            this.groupBox.TabStop = false;
            // 
            // txttotalitem
            // 
            this.txttotalitem.BackColor = System.Drawing.Color.White;
            this.txttotalitem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalitem.Location = new System.Drawing.Point(111, 17);
            this.txttotalitem.Name = "txttotalitem";
            this.txttotalitem.ReadOnly = true;
            this.txttotalitem.Size = new System.Drawing.Size(74, 23);
            this.txttotalitem.TabIndex = 5;
            this.txttotalitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblTotItem
            // 
            this.lblTotItem.AutoSize = true;
            this.lblTotItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotItem.Location = new System.Drawing.Point(10, 20);
            this.lblTotItem.Name = "lblTotItem";
            this.lblTotItem.Size = new System.Drawing.Size(70, 17);
            this.lblTotItem.TabIndex = 12;
            this.lblTotItem.Text = "Total Item";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(415, 40);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(101, 17);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtcustomername);
            this.groupBox2.Controls.Add(this.txtphoneno);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.lblCustName);
            this.groupBox2.Controls.Add(this.lblAddr);
            this.groupBox2.Location = new System.Drawing.Point(6, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(987, 84);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // txtcustomername
            // 
            this.txtcustomername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.FormattingEnabled = true;
            this.txtcustomername.Location = new System.Drawing.Point(122, 37);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(216, 23);
            this.txtcustomername.TabIndex = 1;
            this.txtcustomername.SelectedIndexChanged += new System.EventHandler(this.txtcustomername_SelectedIndexChanged);
            this.txtcustomername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtphoneno
            // 
            this.txtphoneno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtphoneno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneno.Location = new System.Drawing.Point(522, 37);
            this.txtphoneno.Mask = "00000000000000";
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(118, 23);
            this.txtphoneno.TabIndex = 2;
            this.txtphoneno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(758, 13);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(225, 62);
            this.txtaddress.TabIndex = 3;
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.AutoSize = true;
            this.txtdate.BackColor = System.Drawing.Color.Transparent;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(890, 28);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(35, 17);
            this.txtdate.TabIndex = 17;
            this.txtdate.Text = "date";
            // 
            // txtinvoice
            // 
            this.txtinvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.Location = new System.Drawing.Point(128, 28);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(153, 23);
            this.txtinvoice.TabIndex = 1;
            this.txtinvoice.TextChanged += new System.EventHandler(this.txtinvoice_TextChanged);
            this.txtinvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtinvoice_KeyDown);
            this.txtinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvoice_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(841, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 17);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVoucherNo.Location = new System.Drawing.Point(21, 29);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(81, 17);
            this.lblVoucherNo.TabIndex = 11;
            this.lblVoucherNo.Text = "Voucher No";
            // 
            // grdsales
            // 
            this.grdsales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdsales.BackgroundColor = System.Drawing.Color.White;
            this.grdsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemno,
            this.description,
            this.unit,
            this.quantity,
            this.price,
            this.total,
            this.netamount,
            this.scode_name,
            this.newcost});
            this.grdsales.Location = new System.Drawing.Point(6, 14);
            this.grdsales.Name = "grdsales";
            this.grdsales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdsales.Size = new System.Drawing.Size(977, 179);
            this.grdsales.TabIndex = 4;
            this.grdsales.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdsales_CellBeginEdit);
            this.grdsales.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdsales_CellEndEdit);
            this.grdsales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdsales_CellValueChanged);
            // 
            // itemno
            // 
            this.itemno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.itemno.HeaderText = "Item No";
            this.itemno.Name = "itemno";
            this.itemno.Width = 85;
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
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle2;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle3;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // netamount
            // 
            this.netamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.netamount.DefaultCellStyle = dataGridViewCellStyle4;
            this.netamount.HeaderText = "Net.Amt";
            this.netamount.Name = "netamount";
            // 
            // scode_name
            // 
            this.scode_name.HeaderText = "Scode/Name";
            this.scode_name.Name = "scode_name";
            // 
            // newcost
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.newcost.DefaultCellStyle = dataGridViewCellStyle5;
            this.newcost.HeaderText = "New Cost";
            this.newcost.Name = "newcost";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grdsales);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 204);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // frmSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GNetBillingSoft.Properties.Resources.formBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtinvoice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmSalesReturn";
            this.Text = "Sales Return";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorSalesinvoice)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdsales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.TextBox txttotalpaid;
        private System.Windows.Forms.Label lblTotPaid;
        private System.Windows.Forms.TextBox txtpaidcash;
        private System.Windows.Forms.Label lblPaidCash;
        private System.Windows.Forms.TextBox txtadddiscount;
        private System.Windows.Forms.Label lblAdDiscount;
        private System.Windows.Forms.TextBox txtnetamt;
        private System.Windows.Forms.Label lblNetAmnt;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnmainclose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorSalesinvoice;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txttotalitem;
        private System.Windows.Forms.Label lblTotItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtphoneno;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.DomainUpDown txtinvoice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.DataGridView grdsales;
        private System.Windows.Forms.ComboBox txtcustomername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemno;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn netamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn scode_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn newcost;

    }
}