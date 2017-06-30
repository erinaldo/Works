namespace GNetBillingSoft
{
    partial class frmsalescashsummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.timefrom = new System.Windows.Forms.DateTimePicker();
            this.timeto = new System.Windows.Forms.DateTimePicker();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.grdtotal = new System.Windows.Forms.DataGridView();
            this.tot_itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tot_sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdsales = new System.Windows.Forms.DataGridView();
            this.itemname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitysold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesincome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpExpns = new System.Windows.Forms.GroupBox();
            this.grdExpenses = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblexptot = new System.Windows.Forms.Label();
            this.lblTotExpens = new System.Windows.Forms.Label();
            this.grpAcc = new System.Windows.Forms.GroupBox();
            this.txtshort = new System.Windows.Forms.TextBox();
            this.txtexcess = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txtexpenses = new System.Windows.Forms.TextBox();
            this.txttotalsales = new System.Windows.Forms.TextBox();
            this.txtprevbalance = new System.Windows.Forms.TextBox();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblExcess = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.lblExpns = new System.Windows.Forms.Label();
            this.lblTotSale = new System.Windows.Forms.Label();
            this.lblPrevBal = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdsales)).BeginInit();
            this.grpExpns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grpAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(9, 15);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From";
            // 
            // dtfrom
            // 
            this.dtfrom.CustomFormat = "dd/MM/yyyy";
            this.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfrom.Location = new System.Drawing.Point(57, 10);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(96, 20);
            this.dtfrom.TabIndex = 2;
            this.dtfrom.ValueChanged += new System.EventHandler(this.dtfrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(312, 10);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(96, 20);
            this.dtTo.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(276, 15);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // timefrom
            // 
            this.timefrom.CustomFormat = "hh:mm tt ";
            this.timefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timefrom.Location = new System.Drawing.Point(159, 10);
            this.timefrom.Name = "timefrom";
            this.timefrom.ShowUpDown = true;
            this.timefrom.Size = new System.Drawing.Size(68, 20);
            this.timefrom.TabIndex = 13;
            this.timefrom.Value = new System.DateTime(2014, 6, 4, 0, 0, 0, 0);
            // 
            // timeto
            // 
            this.timeto.CustomFormat = "hh:mm tt";
            this.timeto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeto.Location = new System.Drawing.Point(414, 10);
            this.timeto.Name = "timeto";
            this.timeto.ShowUpDown = true;
            this.timeto.Size = new System.Drawing.Size(68, 20);
            this.timeto.TabIndex = 14;
            this.timeto.UseWaitCursor = true;
            this.timeto.Value = new System.DateTime(2014, 6, 4, 23, 59, 0, 0);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.grdtotal);
            this.grpSummary.Controls.Add(this.grdsales);
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpSummary.Location = new System.Drawing.Point(12, 51);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(597, 373);
            this.grpSummary.TabIndex = 15;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "SALES AND CASH SUMMARY";
            // 
            // grdtotal
            // 
            this.grdtotal.AllowUserToAddRows = false;
            this.grdtotal.AllowUserToDeleteRows = false;
            this.grdtotal.AllowUserToResizeColumns = false;
            this.grdtotal.AllowUserToResizeRows = false;
            this.grdtotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdtotal.BackgroundColor = System.Drawing.Color.White;
            this.grdtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdtotal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdtotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdtotal.ColumnHeadersVisible = false;
            this.grdtotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tot_itemname,
            this.tot_quantity,
            this.tot_cost,
            this.tot_sales});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdtotal.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdtotal.Location = new System.Drawing.Point(2, 343);
            this.grdtotal.Name = "grdtotal";
            this.grdtotal.ReadOnly = true;
            this.grdtotal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdtotal.Size = new System.Drawing.Size(568, 25);
            this.grdtotal.TabIndex = 3;
            // 
            // tot_itemname
            // 
            this.tot_itemname.DataPropertyName = "total";
            this.tot_itemname.HeaderText = "Item Name";
            this.tot_itemname.Name = "tot_itemname";
            this.tot_itemname.ReadOnly = true;
            // 
            // tot_quantity
            // 
            this.tot_quantity.DataPropertyName = "totqty";
            this.tot_quantity.HeaderText = "Quantity";
            this.tot_quantity.Name = "tot_quantity";
            this.tot_quantity.ReadOnly = true;
            // 
            // tot_cost
            // 
            this.tot_cost.DataPropertyName = "totcost";
            this.tot_cost.HeaderText = "Cost";
            this.tot_cost.Name = "tot_cost";
            this.tot_cost.ReadOnly = true;
            // 
            // tot_sales
            // 
            this.tot_sales.DataPropertyName = "totsales";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tot_sales.DefaultCellStyle = dataGridViewCellStyle1;
            this.tot_sales.HeaderText = "Sales";
            this.tot_sales.Name = "tot_sales";
            this.tot_sales.ReadOnly = true;
            // 
            // grdsales
            // 
            this.grdsales.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.grdsales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdsales.BackgroundColor = System.Drawing.Color.White;
            this.grdsales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdsales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdsales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemname,
            this.quantitysold,
            this.values,
            this.salesincome,
            this.stock,
            this.groupname});
            this.grdsales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdsales.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdsales.Location = new System.Drawing.Point(3, 19);
            this.grdsales.Name = "grdsales";
            this.grdsales.ReadOnly = true;
            this.grdsales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.grdsales.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdsales.Size = new System.Drawing.Size(591, 351);
            this.grdsales.TabIndex = 16;
            this.grdsales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdsales_CellValueChanged);
            this.grdsales.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdsales_RowPostPaint);
            this.grdsales.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.grdsales_RowsAdded);
            // 
            // itemname
            // 
            this.itemname.DataPropertyName = "Description";
            this.itemname.HeaderText = "Item Name";
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Width = 105;
            // 
            // quantitysold
            // 
            this.quantitysold.DataPropertyName = "quantity";
            this.quantitysold.HeaderText = "Qty Sold";
            this.quantitysold.Name = "quantitysold";
            this.quantitysold.ReadOnly = true;
            this.quantitysold.Width = 106;
            // 
            // values
            // 
            this.values.DataPropertyName = "totalcost";
            this.values.HeaderText = "Value";
            this.values.Name = "values";
            this.values.ReadOnly = true;
            this.values.Width = 105;
            // 
            // salesincome
            // 
            this.salesincome.DataPropertyName = "totsales";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.salesincome.DefaultCellStyle = dataGridViewCellStyle4;
            this.salesincome.HeaderText = "Sales Income";
            this.salesincome.Name = "salesincome";
            this.salesincome.ReadOnly = true;
            this.salesincome.Width = 106;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // groupname
            // 
            this.groupname.DataPropertyName = "itemname";
            this.groupname.HeaderText = "groupname";
            this.groupname.Name = "groupname";
            this.groupname.ReadOnly = true;
            this.groupname.Visible = false;
            // 
            // grpExpns
            // 
            this.grpExpns.Controls.Add(this.grdExpenses);
            this.grpExpns.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpExpns.Location = new System.Drawing.Point(615, 51);
            this.grpExpns.Name = "grpExpns";
            this.grpExpns.Size = new System.Drawing.Size(470, 245);
            this.grpExpns.TabIndex = 16;
            this.grpExpns.TabStop = false;
            this.grpExpns.Text = "EXPENSES";
            // 
            // grdExpenses
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grdExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grdExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdExpenses.BackgroundColor = System.Drawing.Color.White;
            this.grdExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdExpenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.grdExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.amount});
            this.grdExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdExpenses.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grdExpenses.Location = new System.Drawing.Point(3, 19);
            this.grdExpenses.Name = "grdExpenses";
            this.grdExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grdExpenses.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdExpenses.Size = new System.Drawing.Size(464, 223);
            this.grdExpenses.TabIndex = 16;
            this.grdExpenses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExpenses_CellEndEdit);
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.lblexptot);
            this.groupBox4.Controls.Add(this.lblTotExpens);
            this.groupBox4.Location = new System.Drawing.Point(618, 261);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 32);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // lblexptot
            // 
            this.lblexptot.AutoSize = true;
            this.lblexptot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblexptot.Location = new System.Drawing.Point(423, 13);
            this.lblexptot.Name = "lblexptot";
            this.lblexptot.Size = new System.Drawing.Size(14, 15);
            this.lblexptot.TabIndex = 2;
            this.lblexptot.Text = "0";
            // 
            // lblTotExpens
            // 
            this.lblTotExpens.AutoSize = true;
            this.lblTotExpens.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotExpens.Location = new System.Drawing.Point(49, 13);
            this.lblTotExpens.Name = "lblTotExpens";
            this.lblTotExpens.Size = new System.Drawing.Size(89, 15);
            this.lblTotExpens.TabIndex = 0;
            this.lblTotExpens.Text = "Total Expenses";
            // 
            // grpAcc
            // 
            this.grpAcc.Controls.Add(this.txtshort);
            this.grpAcc.Controls.Add(this.txtexcess);
            this.grpAcc.Controls.Add(this.txtbalance);
            this.grpAcc.Controls.Add(this.txtexpenses);
            this.grpAcc.Controls.Add(this.txttotalsales);
            this.grpAcc.Controls.Add(this.txtprevbalance);
            this.grpAcc.Controls.Add(this.lblShort);
            this.grpAcc.Controls.Add(this.lblExcess);
            this.grpAcc.Controls.Add(this.lblBal);
            this.grpAcc.Controls.Add(this.lblExpns);
            this.grpAcc.Controls.Add(this.lblTotSale);
            this.grpAcc.Controls.Add(this.lblPrevBal);
            this.grpAcc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpAcc.Location = new System.Drawing.Point(615, 302);
            this.grpAcc.Name = "grpAcc";
            this.grpAcc.Size = new System.Drawing.Size(470, 122);
            this.grpAcc.TabIndex = 17;
            this.grpAcc.TabStop = false;
            this.grpAcc.Text = "ACCOUNTS";
            // 
            // txtshort
            // 
            this.txtshort.Location = new System.Drawing.Point(384, 79);
            this.txtshort.Name = "txtshort";
            this.txtshort.Size = new System.Drawing.Size(80, 23);
            this.txtshort.TabIndex = 12;
            this.txtshort.Text = "0";
            // 
            // txtexcess
            // 
            this.txtexcess.Location = new System.Drawing.Point(384, 49);
            this.txtexcess.Name = "txtexcess";
            this.txtexcess.Size = new System.Drawing.Size(80, 23);
            this.txtexcess.TabIndex = 11;
            this.txtexcess.Text = "0";
            // 
            // txtbalance
            // 
            this.txtbalance.BackColor = System.Drawing.Color.White;
            this.txtbalance.Location = new System.Drawing.Point(384, 19);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.ReadOnly = true;
            this.txtbalance.Size = new System.Drawing.Size(80, 23);
            this.txtbalance.TabIndex = 10;
            // 
            // txtexpenses
            // 
            this.txtexpenses.BackColor = System.Drawing.Color.White;
            this.txtexpenses.Location = new System.Drawing.Point(160, 80);
            this.txtexpenses.Name = "txtexpenses";
            this.txtexpenses.ReadOnly = true;
            this.txtexpenses.Size = new System.Drawing.Size(80, 23);
            this.txtexpenses.TabIndex = 9;
            // 
            // txttotalsales
            // 
            this.txttotalsales.BackColor = System.Drawing.Color.White;
            this.txttotalsales.Location = new System.Drawing.Point(160, 50);
            this.txttotalsales.Name = "txttotalsales";
            this.txttotalsales.ReadOnly = true;
            this.txttotalsales.Size = new System.Drawing.Size(80, 23);
            this.txttotalsales.TabIndex = 8;
            // 
            // txtprevbalance
            // 
            this.txtprevbalance.Location = new System.Drawing.Point(160, 19);
            this.txtprevbalance.Name = "txtprevbalance";
            this.txtprevbalance.Size = new System.Drawing.Size(80, 23);
            this.txtprevbalance.TabIndex = 7;
            this.txtprevbalance.Text = "0";
            this.txtprevbalance.TextChanged += new System.EventHandler(this.txtprevbalance_TextChanged);
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblShort.Location = new System.Drawing.Point(289, 82);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(42, 13);
            this.lblShort.TabIndex = 6;
            this.lblShort.Text = "SHORT";
            // 
            // lblExcess
            // 
            this.lblExcess.AutoSize = true;
            this.lblExcess.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblExcess.Location = new System.Drawing.Point(289, 53);
            this.lblExcess.Name = "lblExcess";
            this.lblExcess.Size = new System.Drawing.Size(45, 13);
            this.lblExcess.TabIndex = 5;
            this.lblExcess.Text = "EXCESS";
            // 
            // lblBal
            // 
            this.lblBal.AutoSize = true;
            this.lblBal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBal.Location = new System.Drawing.Point(289, 22);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(58, 13);
            this.lblBal.TabIndex = 4;
            this.lblBal.Text = "BALANCE";
            // 
            // lblExpns
            // 
            this.lblExpns.AutoSize = true;
            this.lblExpns.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblExpns.Location = new System.Drawing.Point(25, 83);
            this.lblExpns.Name = "lblExpns";
            this.lblExpns.Size = new System.Drawing.Size(60, 13);
            this.lblExpns.TabIndex = 3;
            this.lblExpns.Text = "EXPENSES";
            // 
            // lblTotSale
            // 
            this.lblTotSale.AutoSize = true;
            this.lblTotSale.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotSale.Location = new System.Drawing.Point(25, 53);
            this.lblTotSale.Name = "lblTotSale";
            this.lblTotSale.Size = new System.Drawing.Size(76, 13);
            this.lblTotSale.TabIndex = 2;
            this.lblTotSale.Text = "TOTAL SALES";
            // 
            // lblPrevBal
            // 
            this.lblPrevBal.AutoSize = true;
            this.lblPrevBal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPrevBal.Location = new System.Drawing.Point(25, 22);
            this.lblPrevBal.Name = "lblPrevBal";
            this.lblPrevBal.Size = new System.Drawing.Size(113, 13);
            this.lblPrevBal.TabIndex = 0;
            this.lblPrevBal.Text = "PREVIOUS BALANCE";
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnshow.Location = new System.Drawing.Point(497, 10);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 17;
            this.btnshow.Text = "SHOW";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprint.Location = new System.Drawing.Point(578, 11);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 23);
            this.btnprint.TabIndex = 18;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // frmsalescashsummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1093, 436);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.grpAcc);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpExpns);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.timefrom);
            this.Controls.Add(this.timeto);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtfrom);
            this.Controls.Add(this.lblFrom);
            this.MaximizeBox = false;
            this.Name = "frmsalescashsummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales and Cash Summery";
            this.Load += new System.EventHandler(this.frmsalescashsummary_Load);
            this.grpSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdsales)).EndInit();
            this.grpExpns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpAcc.ResumeLayout(false);
            this.grpAcc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtfrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker timefrom;
        private System.Windows.Forms.DateTimePicker timeto;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.DataGridView grdsales;
        private System.Windows.Forms.GroupBox grpExpns;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblexptot;
        private System.Windows.Forms.Label lblTotExpens;
        private System.Windows.Forms.DataGridView grdExpenses;
        private System.Windows.Forms.DataGridView grdtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn tot_sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.GroupBox grpAcc;
        private System.Windows.Forms.TextBox txtshort;
        private System.Windows.Forms.TextBox txtexcess;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txtexpenses;
        private System.Windows.Forms.TextBox txttotalsales;
        private System.Windows.Forms.TextBox txtprevbalance;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblExcess;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label lblExpns;
        private System.Windows.Forms.Label lblTotSale;
        private System.Windows.Forms.Label lblPrevBal;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitysold;
        private System.Windows.Forms.DataGridViewTextBoxColumn values;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesincome;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupname;
        private System.Windows.Forms.Button btnprint;
    }
}