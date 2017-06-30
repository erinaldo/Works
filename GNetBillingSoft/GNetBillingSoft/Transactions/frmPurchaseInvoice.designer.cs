namespace GNetBillingSoft.Transactions
{
    partial class frmPurchaseInvoice
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
            this.lblAdDiscount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.itemno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtinvoice = new System.Windows.Forms.DomainUpDown();
            this.txtdate = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtopening = new System.Windows.Forms.MaskedTextBox();
            this.lblOppBal = new System.Windows.Forms.Label();
            this.txtsupplier = new System.Windows.Forms.ComboBox();
            this.txtreferenno = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.txtphonenumber = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblsuppliename = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnetamount
            // 
            this.txtnetamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnetamount.BackColor = System.Drawing.Color.White;
            this.txtnetamount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetamount.Location = new System.Drawing.Point(128, 18);
            this.txtnetamount.Name = "txtnetamount";
            this.txtnetamount.ReadOnly = true;
            this.txtnetamount.Size = new System.Drawing.Size(103, 23);
            this.txtnetamount.TabIndex = 11;
            this.txtnetamount.Text = "0.00";
            this.txtnetamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtnetamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblNetTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetTotal.Location = new System.Drawing.Point(15, 21);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(59, 15);
            this.lblNetTotal.TabIndex = 16;
            this.lblNetTotal.Text = "Net Total";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtdiscount.BackColor = System.Drawing.Color.White;
            this.txtdiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(313, 20);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(79, 23);
            this.txtdiscount.TabIndex = 9;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(232, 23);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(78, 17);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "Discount %";
            // 
            // txttotitem
            // 
            this.txttotitem.BackColor = System.Drawing.Color.White;
            this.txttotitem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotitem.Location = new System.Drawing.Point(114, 21);
            this.txttotitem.Name = "txttotitem";
            this.txttotitem.ReadOnly = true;
            this.txttotitem.Size = new System.Drawing.Size(91, 23);
            this.txttotitem.TabIndex = 8;
            this.txttotitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblTotItem
            // 
            this.lblTotItem.AutoSize = true;
            this.lblTotItem.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblTotItem.Location = new System.Drawing.Point(8, 23);
            this.lblTotItem.Name = "lblTotItem";
            this.lblTotItem.Size = new System.Drawing.Size(72, 17);
            this.lblTotItem.TabIndex = 12;
            this.lblTotItem.Text = "Total Item";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtpaidcash);
            this.groupBox4.Controls.Add(this.txtnetamount);
            this.groupBox4.Controls.Add(this.txtBalance);
            this.groupBox4.Controls.Add(this.lblNetTotal);
            this.groupBox4.Controls.Add(this.lblBal);
            this.groupBox4.Controls.Add(this.txtpaid);
            this.groupBox4.Controls.Add(this.lblTotPaid);
            this.groupBox4.Controls.Add(this.txtpaidcheque);
            this.groupBox4.Controls.Add(this.lblPaidCheq);
            this.groupBox4.Controls.Add(this.lblPaidCash);
            this.groupBox4.Location = new System.Drawing.Point(659, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 185);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 2);
            this.label1.TabIndex = 30;
            this.label1.Text = "label1";
            // 
            // txtpaidcash
            // 
            this.txtpaidcash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidcash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtpaidcash.Location = new System.Drawing.Point(128, 59);
            this.txtpaidcash.Name = "txtpaidcash";
            this.txtpaidcash.Size = new System.Drawing.Size(103, 25);
            this.txtpaidcash.TabIndex = 12;
            this.txtpaidcash.Text = "0.00";
            this.txtpaidcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpaidcash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpaidcash_KeyPress);
            this.txtpaidcash.Leave += new System.EventHandler(this.txtpaidcash_Leave);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBalance.Location = new System.Drawing.Point(128, 149);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(103, 25);
            this.txtBalance.TabIndex = 15;
            this.txtBalance.Text = "0.00";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBal.Location = new System.Drawing.Point(14, 152);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(55, 17);
            this.lblBal.TabIndex = 22;
            this.lblBal.Text = "Balance";
            this.lblBal.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtpaid
            // 
            this.txtpaid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtpaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaid.ForeColor = System.Drawing.Color.Navy;
            this.txtpaid.Location = new System.Drawing.Point(128, 120);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.ReadOnly = true;
            this.txtpaid.Size = new System.Drawing.Size(103, 25);
            this.txtpaid.TabIndex = 14;
            this.txtpaid.Text = "0.00";
            this.txtpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblTotPaid
            // 
            this.lblTotPaid.AutoSize = true;
            this.lblTotPaid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPaid.ForeColor = System.Drawing.Color.Navy;
            this.lblTotPaid.Location = new System.Drawing.Point(14, 123);
            this.lblTotPaid.Name = "lblTotPaid";
            this.lblTotPaid.Size = new System.Drawing.Size(71, 17);
            this.lblTotPaid.TabIndex = 20;
            this.lblTotPaid.Text = "Total Paid";
            // 
            // txtpaidcheque
            // 
            this.txtpaidcheque.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidcheque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtpaidcheque.Location = new System.Drawing.Point(128, 91);
            this.txtpaidcheque.Name = "txtpaidcheque";
            this.txtpaidcheque.Size = new System.Drawing.Size(103, 25);
            this.txtpaidcheque.TabIndex = 13;
            this.txtpaidcheque.Text = "0.00";
            this.txtpaidcheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpaidcheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtpaidcheque.Leave += new System.EventHandler(this.txtpaidcheque_Leave);
            // 
            // lblPaidCheq
            // 
            this.lblPaidCheq.AutoSize = true;
            this.lblPaidCheq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidCheq.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPaidCheq.Location = new System.Drawing.Point(14, 94);
            this.lblPaidCheq.Name = "lblPaidCheq";
            this.lblPaidCheq.Size = new System.Drawing.Size(85, 17);
            this.lblPaidCheq.TabIndex = 18;
            this.lblPaidCheq.Text = "Paid Cheque";
            // 
            // lblPaidCash
            // 
            this.lblPaidCash.AutoSize = true;
            this.lblPaidCash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidCash.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPaidCash.Location = new System.Drawing.Point(14, 62);
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
            this.groupBox3.Controls.Add(this.lblAdDiscount);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.txtdiscount);
            this.groupBox3.Controls.Add(this.lblDiscount);
            this.groupBox3.Controls.Add(this.txttotitem);
            this.groupBox3.Controls.Add(this.lblTotItem);
            this.groupBox3.Location = new System.Drawing.Point(6, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(632, 58);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // lblAdDiscount
            // 
            this.lblAdDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdDiscount.AutoSize = true;
            this.lblAdDiscount.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.errorProvider.SetIconAlignment(this.lblAdDiscount, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.lblAdDiscount.Location = new System.Drawing.Point(428, 23);
            this.lblAdDiscount.Name = "lblAdDiscount";
            this.lblAdDiscount.Size = new System.Drawing.Size(92, 17);
            this.lblAdDiscount.TabIndex = 17;
            this.lblAdDiscount.Text = "Add.Discount";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorProvider.SetIconAlignment(this.textBox1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.textBox1.Location = new System.Drawing.Point(521, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblphonenumber.Location = new System.Drawing.Point(309, 16);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(101, 17);
            this.lblphonenumber.TabIndex = 7;
            this.lblphonenumber.Text = "Phone Number";
            // 
            // lbladdress
            // 
            this.lbladdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbladdress.Location = new System.Drawing.Point(617, 16);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(57, 17);
            this.lbladdress.TabIndex = 5;
            this.lbladdress.Text = "Address";
            // 
            // grdItems
            // 
            this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItems.BackgroundColor = System.Drawing.Color.White;
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemno,
            this.description,
            this.unit,
            this.quantity,
            this.price,
            this.total,
            this.netamount,
            this.sellingprice,
            this.purchaseid});
            this.grdItems.Location = new System.Drawing.Point(4, 162);
            this.grdItems.Name = "grdItems";
            this.grdItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdItems.Size = new System.Drawing.Size(902, 181);
            this.grdItems.TabIndex = 7;
            this.grdItems.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdItems_CellBeginEdit);
            this.grdItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellEndEdit);
            this.grdItems.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellLeave);
            this.grdItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdItems_CellValueChanged);
            this.grdItems.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grdItems_EditingControlShowing);
            this.grdItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grdItems_RowsRemoved);
            this.grdItems.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdItems_UserAddedRow);
            this.grdItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdItems_KeyDown);
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
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.unit.FillWeight = 36.08248F;
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantity.FillWeight = 36.08248F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle2;
            this.price.FillWeight = 36.08248F;
            this.price.HeaderText = "Cost";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle3;
            this.total.FillWeight = 36.08248F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // netamount
            // 
            this.netamount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.netamount.DefaultCellStyle = dataGridViewCellStyle4;
            this.netamount.FillWeight = 36.08248F;
            this.netamount.HeaderText = "Net.Amt";
            this.netamount.Name = "netamount";
            this.netamount.ReadOnly = true;
            // 
            // sellingprice
            // 
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.sellingprice.DefaultCellStyle = dataGridViewCellStyle5;
            this.sellingprice.HeaderText = "Selling Price";
            this.sellingprice.Name = "sellingprice";
            // 
            // purchaseid
            // 
            this.purchaseid.HeaderText = "purchaseid";
            this.purchaseid.Name = "purchaseid";
            this.purchaseid.Visible = false;
            // 
            // txtinvoice
            // 
            this.txtinvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.Location = new System.Drawing.Point(108, 22);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(153, 23);
            this.txtinvoice.TabIndex = 1;
            this.txtinvoice.TextChanged += new System.EventHandler(this.txtinvoice_TextChanged);
            this.txtinvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtinvoice_KeyDown);
            this.txtinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvoice_KeyPress);
            this.txtinvoice.Leave += new System.EventHandler(this.txtinvoice_Leave);
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.AutoSize = true;
            this.txtdate.BackColor = System.Drawing.Color.Transparent;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.txtdate.Location = new System.Drawing.Point(815, 26);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(38, 19);
            this.txtdate.TabIndex = 15;
            this.txtdate.Text = "Date";
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbldate.Location = new System.Drawing.Point(764, 26);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(38, 19);
            this.lbldate.TabIndex = 13;
            this.lbldate.Text = "Date";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucherNo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblVoucherNo.Location = new System.Drawing.Point(12, 24);
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
            this.groupBox2.Controls.Add(this.txtopening);
            this.groupBox2.Controls.Add(this.lblOppBal);
            this.groupBox2.Controls.Add(this.txtsupplier);
            this.groupBox2.Controls.Add(this.txtreferenno);
            this.groupBox2.Controls.Add(this.lblRef);
            this.groupBox2.Controls.Add(this.txtphonenumber);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.lblsuppliename);
            this.groupBox2.Controls.Add(this.lblphonenumber);
            this.groupBox2.Controls.Add(this.lbladdress);
            this.groupBox2.Location = new System.Drawing.Point(4, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtopening
            // 
            this.txtopening.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtopening.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopening.Location = new System.Drawing.Point(411, 49);
            this.txtopening.Name = "txtopening";
            this.txtopening.Size = new System.Drawing.Size(153, 23);
            this.txtopening.TabIndex = 5;
            this.txtopening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblOppBal
            // 
            this.lblOppBal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblOppBal.AutoSize = true;
            this.lblOppBal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOppBal.Location = new System.Drawing.Point(314, 52);
            this.lblOppBal.Name = "lblOppBal";
            this.lblOppBal.Size = new System.Drawing.Size(85, 17);
            this.lblOppBal.TabIndex = 16;
            this.lblOppBal.Text = "Opp.Balance";
            // 
            // txtsupplier
            // 
            this.txtsupplier.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupplier.FormattingEnabled = true;
            this.txtsupplier.Location = new System.Drawing.Point(104, 12);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(153, 23);
            this.txtsupplier.TabIndex = 2;
            this.txtsupplier.SelectedIndexChanged += new System.EventHandler(this.txtsupplier_SelectedIndexChanged);
            this.txtsupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            this.txtsupplier.Leave += new System.EventHandler(this.txtsupplier_Leave);
            // 
            // txtreferenno
            // 
            this.txtreferenno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferenno.Location = new System.Drawing.Point(104, 49);
            this.txtreferenno.Name = "txtreferenno";
            this.txtreferenno.Size = new System.Drawing.Size(153, 23);
            this.txtreferenno.TabIndex = 3;
            this.txtreferenno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblRef.Location = new System.Drawing.Point(6, 52);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(88, 17);
            this.lblRef.TabIndex = 14;
            this.lblRef.Text = "Reference no";
            this.lblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtphonenumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonenumber.Location = new System.Drawing.Point(411, 13);
            this.txtphonenumber.Mask = "00000000000000";
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(153, 23);
            this.txtphonenumber.TabIndex = 4;
            this.txtphonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(680, 13);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(191, 63);
            this.txtaddress.TabIndex = 6;
            // 
            // lblsuppliename
            // 
            this.lblsuppliename.AutoSize = true;
            this.lblsuppliename.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblsuppliename.Location = new System.Drawing.Point(6, 15);
            this.lblsuppliename.Name = "lblsuppliename";
            this.lblsuppliename.Size = new System.Drawing.Size(91, 17);
            this.lblsuppliename.TabIndex = 12;
            this.lblsuppliename.Text = "Suplier Name";
            this.lblsuppliename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.BackgroundImage = global::GNetBillingSoft.Properties.Resources.eraser_icon;
            this.btnclear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(470, 478);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 56);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // chkPrint
            // 
            this.chkPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrint.AutoSize = true;
            this.chkPrint.BackColor = System.Drawing.Color.Transparent;
            this.chkPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkPrint.Location = new System.Drawing.Point(106, 455);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(116, 17);
            this.chkPrint.TabIndex = 13;
            this.chkPrint.Text = "Print while save";
            this.chkPrint.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = global::GNetBillingSoft.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(379, 478);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 56);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::GNetBillingSoft.Properties.Resources.red_cross_icon_215331;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(563, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 56);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = global::GNetBillingSoft.Properties.Resources.delete_xxl;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(286, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 56);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.BackgroundImage = global::GNetBillingSoft.Properties.Resources.edit_notes_icons_21;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnedit.FlatAppearance.BorderSize = 0;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(194, 478);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 56);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = global::GNetBillingSoft.Properties.Resources.Save_icon;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(101, 478);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 56);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmPurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GNetBillingSoft.Properties.Resources.formBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 560);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtinvoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grdItems);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPurchaseInvoice";
            this.Text = "Purchase Invoice";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmpurchaseinvoice_KeyDown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnetamount;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txttotitem;
        private System.Windows.Forms.Label lblTotItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.Label lblTotPaid;
        private System.Windows.Forms.TextBox txtpaidcheque;
        private System.Windows.Forms.Label lblPaidCheq;
        private System.Windows.Forms.Label lblPaidCash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblsuppliename;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label txtdate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtpaidcash;
        private System.Windows.Forms.DomainUpDown txtinvoice;
        private System.Windows.Forms.TextBox txtreferenno;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox txtsupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemno;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewComboBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn netamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseid;
        private System.Windows.Forms.MaskedTextBox txtopening;
        private System.Windows.Forms.Label lblOppBal;
        private System.Windows.Forms.Label lblAdDiscount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}