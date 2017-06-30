namespace GNetBillingSoft.Transactions
{
    partial class frmPOS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdPOS = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouplayout = new System.Windows.Forms.FlowLayoutPanel();
            this.childlayout = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttokenno = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.MaskedTextBox();
            this.txtopening = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtinvoiceno = new System.Windows.Forms.DomainUpDown();
            this.txtphoneno = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtdiscamount = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdisc = new System.Windows.Forms.TextBox();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnseven = new System.Windows.Forms.Button();
            this.btneight = new System.Windows.Forms.Button();
            this.btnnine = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnfour = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnone = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btngridclear = new System.Windows.Forms.Button();
            this.btnunits = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnreceipt = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtnewbalance = new System.Windows.Forms.TextBox();
            this.txtoldbalance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorPOS = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPOS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.grdPOS);
            this.groupBox1.Location = new System.Drawing.Point(3, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grdPOS
            // 
            this.grdPOS.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPOS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.description,
            this.unit,
            this.quantity,
            this.uprice,
            this.total,
            this.itemid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPOS.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPOS.Location = new System.Drawing.Point(3, 16);
            this.grdPOS.Name = "grdPOS";
            this.grdPOS.RowTemplate.Height = 30;
            this.grdPOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdPOS.Size = new System.Drawing.Size(668, 224);
            this.grdPOS.TabIndex = 0;
            this.grdPOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPOS_CellClick);
            this.grdPOS.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPOS_CellEndEdit);
            this.grdPOS.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPOS_CellLeave);
            this.grdPOS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPOS_CellValueChanged);
            this.grdPOS.Enter += new System.EventHandler(this.txtpaid_Enter);
            this.grdPOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdPOS_KeyDown);
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.FillWeight = 25.34162F;
            this.number.HeaderText = "NO";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.FillWeight = 76.29646F;
            this.description.HeaderText = "DESCRIPTION";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.FillWeight = 24.27576F;
            this.unit.HeaderText = "UNIT";
            this.unit.Name = "unit";
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantity.FillWeight = 38.20764F;
            this.quantity.HeaderText = "QTY";
            this.quantity.Name = "quantity";
            // 
            // uprice
            // 
            this.uprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uprice.FillWeight = 33.93775F;
            this.uprice.HeaderText = "UPRICE";
            this.uprice.Name = "uprice";
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.FillWeight = 67.36709F;
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            // 
            // itemid
            // 
            this.itemid.HeaderText = "itemid";
            this.itemid.Name = "itemid";
            this.itemid.Visible = false;
            // 
            // grouplayout
            // 
            this.grouplayout.AutoScroll = true;
            this.grouplayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouplayout.Location = new System.Drawing.Point(3, 16);
            this.grouplayout.Margin = new System.Windows.Forms.Padding(2);
            this.grouplayout.Name = "grouplayout";
            this.grouplayout.Size = new System.Drawing.Size(1015, 173);
            this.grouplayout.TabIndex = 0;
            this.grouplayout.Paint += new System.Windows.Forms.PaintEventHandler(this.grouplayout_Paint);
            // 
            // childlayout
            // 
            this.childlayout.AutoScroll = true;
            this.childlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childlayout.Location = new System.Drawing.Point(3, 16);
            this.childlayout.Name = "childlayout";
            this.childlayout.Size = new System.Drawing.Size(279, 492);
            this.childlayout.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.grouplayout);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1021, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.childlayout);
            this.groupBox3.Location = new System.Drawing.Point(1027, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 511);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtbarcode);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txttokenno);
            this.groupBox4.Controls.Add(this.txtdate);
            this.groupBox4.Controls.Add(this.txtopening);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtinvoiceno);
            this.groupBox4.Controls.Add(this.txtphoneno);
            this.groupBox4.Controls.Add(this.txtaddress);
            this.groupBox4.Controls.Add(this.cmbcustomer);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(3, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(674, 155);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(68, 110);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(162, 20);
            this.txtbarcode.TabIndex = 15;
            this.txtbarcode.TextChanged += new System.EventHandler(this.txtbarcode_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Barcode :";
            // 
            // txttokenno
            // 
            this.txttokenno.Location = new System.Drawing.Point(312, 77);
            this.txttokenno.Name = "txttokenno";
            this.txttokenno.Size = new System.Drawing.Size(73, 20);
            this.txttokenno.TabIndex = 6;
            this.txttokenno.Visible = false;
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.Location = new System.Drawing.Point(598, 13);
            this.txtdate.Mask = "00/00/0000";
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(70, 20);
            this.txtdate.TabIndex = 13;
            // 
            // txtopening
            // 
            this.txtopening.Location = new System.Drawing.Point(310, 103);
            this.txtopening.Name = "txtopening";
            this.txtopening.Size = new System.Drawing.Size(74, 20);
            this.txtopening.TabIndex = 12;
            this.txtopening.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Opp.Bal :";
            this.label13.Visible = false;
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtinvoiceno.Location = new System.Drawing.Point(598, 51);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(70, 20);
            this.txtinvoiceno.TabIndex = 10;
            this.txtinvoiceno.SelectedItemChanged += new System.EventHandler(this.txtinvoiceno_SelectedItemChanged);
            this.txtinvoiceno.TextChanged += new System.EventHandler(this.txtinvoiceno_TextChanged);
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(310, 129);
            this.txtphoneno.Mask = "000000000000000";
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(74, 20);
            this.txtphoneno.TabIndex = 9;
            this.txtphoneno.Visible = false;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(68, 53);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(162, 43);
            this.txtaddress.TabIndex = 6;
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.ItemHeight = 25;
            this.cmbcustomer.Location = new System.Drawing.Point(68, 13);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(162, 33);
            this.cmbcustomer.TabIndex = 5;
            this.cmbcustomer.Leave += new System.EventHandler(this.cmbcustomer_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Invoice No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel :";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer :";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtdiscamount);
            this.groupBox5.Controls.Add(this.txttotal);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtdisc);
            this.groupBox5.Controls.Add(this.txtnet);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(5, 612);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(672, 37);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // txtdiscamount
            // 
            this.txtdiscamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdiscamount.Location = new System.Drawing.Point(489, 13);
            this.txtdiscamount.Name = "txtdiscamount";
            this.txtdiscamount.Size = new System.Drawing.Size(66, 20);
            this.txtdiscamount.TabIndex = 7;
            this.txtdiscamount.TextChanged += new System.EventHandler(this.txtdiscamount_TextChanged);
            this.txtdiscamount.Enter += new System.EventHandler(this.txtpaid_Enter);
            this.txtdiscamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscamount_KeyPress);
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txttotal.Location = new System.Drawing.Point(46, 13);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(64, 20);
            this.txttotal.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total";
            // 
            // txtdisc
            // 
            this.txtdisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdisc.Location = new System.Drawing.Point(450, 13);
            this.txtdisc.Name = "txtdisc";
            this.txtdisc.Size = new System.Drawing.Size(33, 20);
            this.txtdisc.TabIndex = 4;
            this.txtdisc.TextChanged += new System.EventHandler(this.txtdisc_TextChanged);
            this.txtdisc.Enter += new System.EventHandler(this.txtpaid_Enter);
            // 
            // txtnet
            // 
            this.txtnet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtnet.Location = new System.Drawing.Point(597, 13);
            this.txtnet.Name = "txtnet";
            this.txtnet.ReadOnly = true;
            this.txtnet.Size = new System.Drawing.Size(64, 20);
            this.txtnet.TabIndex = 6;
            this.txtnet.TextChanged += new System.EventHandler(this.txtnet_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "DISC %";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "NET";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.flowLayoutPanel1);
            this.groupBox6.Location = new System.Drawing.Point(683, 194);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 325);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.btnseven);
            this.flowLayoutPanel1.Controls.Add(this.btneight);
            this.flowLayoutPanel1.Controls.Add(this.btnnine);
            this.flowLayoutPanel1.Controls.Add(this.btnadd);
            this.flowLayoutPanel1.Controls.Add(this.btnfour);
            this.flowLayoutPanel1.Controls.Add(this.btnfive);
            this.flowLayoutPanel1.Controls.Add(this.btnsix);
            this.flowLayoutPanel1.Controls.Add(this.btnminus);
            this.flowLayoutPanel1.Controls.Add(this.btnone);
            this.flowLayoutPanel1.Controls.Add(this.btntwo);
            this.flowLayoutPanel1.Controls.Add(this.btnthree);
            this.flowLayoutPanel1.Controls.Add(this.btnmultiply);
            this.flowLayoutPanel1.Controls.Add(this.btnzero);
            this.flowLayoutPanel1.Controls.Add(this.btndot);
            this.flowLayoutPanel1.Controls.Add(this.btnequal);
            this.flowLayoutPanel1.Controls.Add(this.btndivide);
            this.flowLayoutPanel1.Controls.Add(this.btnclear);
            this.flowLayoutPanel1.Controls.Add(this.btngridclear);
            this.flowLayoutPanel1.Controls.Add(this.btnunits);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 306);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnseven
            // 
            this.btnseven.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnseven.AutoSize = true;
            this.btnseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseven.Location = new System.Drawing.Point(3, 3);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(76, 52);
            this.btnseven.TabIndex = 0;
            this.btnseven.TabStop = false;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btneight
            // 
            this.btneight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btneight.AutoSize = true;
            this.btneight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneight.Location = new System.Drawing.Point(85, 3);
            this.btneight.Name = "btneight";
            this.btneight.Size = new System.Drawing.Size(76, 52);
            this.btneight.TabIndex = 1;
            this.btneight.TabStop = false;
            this.btneight.Text = "8";
            this.btneight.UseVisualStyleBackColor = true;
            this.btneight.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btnnine
            // 
            this.btnnine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnnine.AutoSize = true;
            this.btnnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnine.Location = new System.Drawing.Point(167, 3);
            this.btnnine.Name = "btnnine";
            this.btnnine.Size = new System.Drawing.Size(76, 52);
            this.btnnine.TabIndex = 2;
            this.btnnine.TabStop = false;
            this.btnnine.Text = "9";
            this.btnnine.UseVisualStyleBackColor = true;
            this.btnnine.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btnadd
            // 
            this.btnadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnadd.AutoSize = true;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(249, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(76, 52);
            this.btnadd.TabIndex = 9;
            this.btnadd.TabStop = false;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btnfour
            // 
            this.btnfour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfour.AutoSize = true;
            this.btnfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfour.Location = new System.Drawing.Point(3, 61);
            this.btnfour.Name = "btnfour";
            this.btnfour.Size = new System.Drawing.Size(76, 52);
            this.btnfour.TabIndex = 4;
            this.btnfour.TabStop = false;
            this.btnfour.Text = "4";
            this.btnfour.UseVisualStyleBackColor = true;
            this.btnfour.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btnfive
            // 
            this.btnfive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnfive.AutoSize = true;
            this.btnfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfive.Location = new System.Drawing.Point(85, 61);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(76, 52);
            this.btnfive.TabIndex = 3;
            this.btnfive.TabStop = false;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = true;
            this.btnfive.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btnsix
            // 
            this.btnsix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsix.AutoSize = true;
            this.btnsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsix.Location = new System.Drawing.Point(167, 61);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(76, 52);
            this.btnsix.TabIndex = 5;
            this.btnsix.TabStop = false;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            this.btnsix.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btnminus
            // 
            this.btnminus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnminus.AutoSize = true;
            this.btnminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(249, 61);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(76, 52);
            this.btnminus.TabIndex = 10;
            this.btnminus.TabStop = false;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btnone
            // 
            this.btnone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnone.AutoSize = true;
            this.btnone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnone.Location = new System.Drawing.Point(3, 119);
            this.btnone.Name = "btnone";
            this.btnone.Size = new System.Drawing.Size(76, 52);
            this.btnone.TabIndex = 6;
            this.btnone.TabStop = false;
            this.btnone.Text = "1";
            this.btnone.UseVisualStyleBackColor = true;
            this.btnone.Click += new System.EventHandler(this.btnaction_click);
            this.btnone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnone_MouseClick);
            // 
            // btntwo
            // 
            this.btntwo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntwo.AutoSize = true;
            this.btntwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwo.Location = new System.Drawing.Point(85, 119);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(76, 52);
            this.btntwo.TabIndex = 7;
            this.btntwo.TabStop = false;
            this.btntwo.Text = "2";
            this.btntwo.UseVisualStyleBackColor = true;
            this.btntwo.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btnthree
            // 
            this.btnthree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnthree.AutoSize = true;
            this.btnthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthree.Location = new System.Drawing.Point(167, 119);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(76, 52);
            this.btnthree.TabIndex = 8;
            this.btnthree.TabStop = false;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmultiply.AutoSize = true;
            this.btnmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiply.Location = new System.Drawing.Point(249, 119);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(76, 52);
            this.btnmultiply.TabIndex = 14;
            this.btnmultiply.TabStop = false;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btnzero
            // 
            this.btnzero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnzero.AutoSize = true;
            this.btnzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.Location = new System.Drawing.Point(3, 177);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(76, 52);
            this.btnzero.TabIndex = 12;
            this.btnzero.TabStop = false;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btndot
            // 
            this.btndot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndot.AutoSize = true;
            this.btndot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.Location = new System.Drawing.Point(85, 177);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(76, 52);
            this.btndot.TabIndex = 13;
            this.btndot.TabStop = false;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.Click += new System.EventHandler(this.btnaction_click);
            // 
            // btnequal
            // 
            this.btnequal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnequal.AutoSize = true;
            this.btnequal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequal.Location = new System.Drawing.Point(167, 177);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(76, 52);
            this.btnequal.TabIndex = 11;
            this.btnequal.TabStop = false;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btndivide
            // 
            this.btndivide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btndivide.AutoSize = true;
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(249, 177);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(76, 52);
            this.btndivide.TabIndex = 15;
            this.btndivide.TabStop = false;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btnoperator_Click);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclear.AutoSize = true;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(3, 235);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(76, 52);
            this.btnclear.TabIndex = 16;
            this.btnclear.TabStop = false;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btngridclear
            // 
            this.btngridclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btngridclear.AutoSize = true;
            this.btngridclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngridclear.Location = new System.Drawing.Point(85, 235);
            this.btngridclear.Name = "btngridclear";
            this.btngridclear.Size = new System.Drawing.Size(75, 52);
            this.btngridclear.TabIndex = 17;
            this.btngridclear.TabStop = false;
            this.btngridclear.Text = "Clear ";
            this.btngridclear.UseVisualStyleBackColor = true;
            this.btngridclear.Click += new System.EventHandler(this.btngridclear_Click);
            // 
            // btnunits
            // 
            this.btnunits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnunits.AutoSize = true;
            this.btnunits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunits.Location = new System.Drawing.Point(166, 235);
            this.btnunits.Name = "btnunits";
            this.btnunits.Size = new System.Drawing.Size(75, 52);
            this.btnunits.TabIndex = 18;
            this.btnunits.TabStop = false;
            this.btnunits.Text = "Units";
            this.btnunits.UseVisualStyleBackColor = true;
            this.btnunits.Click += new System.EventHandler(this.btnunits_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.flowLayoutPanel2);
            this.groupBox7.Location = new System.Drawing.Point(992, 519);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(320, 134);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnreceipt);
            this.flowLayoutPanel2.Controls.Add(this.btnpayment);
            this.flowLayoutPanel2.Controls.Add(this.btndelete);
            this.flowLayoutPanel2.Controls.Add(this.btnreport);
            this.flowLayoutPanel2.Controls.Add(this.btnprint);
            this.flowLayoutPanel2.Controls.Add(this.btnclose);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(314, 115);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnreceipt
            // 
            this.btnreceipt.Image = global::GNetBillingSoft.Properties.Resources.cancel;
            this.btnreceipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnreceipt.Location = new System.Drawing.Point(3, 3);
            this.btnreceipt.Name = "btnreceipt";
            this.btnreceipt.Size = new System.Drawing.Size(98, 50);
            this.btnreceipt.TabIndex = 0;
            this.btnreceipt.Text = "CLOSE SALE";
            this.btnreceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreceipt.UseVisualStyleBackColor = true;
            this.btnreceipt.Click += new System.EventHandler(this.btnreceipt_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.Image = global::GNetBillingSoft.Properties.Resources.credit_card;
            this.btnpayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnpayment.Location = new System.Drawing.Point(107, 3);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(98, 50);
            this.btnpayment.TabIndex = 1;
            this.btnpayment.Text = "PAYMENT";
            this.btnpayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnpayment.UseVisualStyleBackColor = true;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::GNetBillingSoft.Properties.Resources.delete;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndelete.Location = new System.Drawing.Point(211, 3);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 50);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "DELETE";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnreport
            // 
            this.btnreport.Image = global::GNetBillingSoft.Properties.Resources.newspaper;
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnreport.Location = new System.Drawing.Point(3, 59);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(98, 50);
            this.btnreport.TabIndex = 3;
            this.btnreport.Text = "REPORTS";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnprint
            // 
            this.btnprint.Image = global::GNetBillingSoft.Properties.Resources.printer;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnprint.Location = new System.Drawing.Point(107, 59);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(98, 50);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "PRINT";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnclose
            // 
            this.btnclose.Image = global::GNetBillingSoft.Properties.Resources.logout;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnclose.Location = new System.Drawing.Point(211, 59);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(98, 50);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "CLOSE";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.txtnewbalance);
            this.groupBox8.Controls.Add(this.txtoldbalance);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.btnEdit);
            this.groupBox8.Controls.Add(this.txtbalance);
            this.groupBox8.Controls.Add(this.txtpaid);
            this.groupBox8.Controls.Add(this.btnenter);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Location = new System.Drawing.Point(686, 519);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(302, 134);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            // 
            // txtnewbalance
            // 
            this.txtnewbalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtnewbalance.Location = new System.Drawing.Point(82, 110);
            this.txtnewbalance.Name = "txtnewbalance";
            this.txtnewbalance.Size = new System.Drawing.Size(100, 20);
            this.txtnewbalance.TabIndex = 13;
            // 
            // txtoldbalance
            // 
            this.txtoldbalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtoldbalance.Location = new System.Drawing.Point(82, 79);
            this.txtoldbalance.Name = "txtoldbalance";
            this.txtoldbalance.Size = new System.Drawing.Size(100, 20);
            this.txtoldbalance.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "NEW BAL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "OLD BAL";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEdit.Image = global::GNetBillingSoft.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(190, 76);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 50);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtbalance
            // 
            this.txtbalance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtbalance.Location = new System.Drawing.Point(82, 44);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(100, 20);
            this.txtbalance.TabIndex = 8;
            this.txtbalance.Enter += new System.EventHandler(this.txtpaid_Enter);
            // 
            // txtpaid
            // 
            this.txtpaid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpaid.Location = new System.Drawing.Point(82, 13);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(100, 20);
            this.txtpaid.TabIndex = 7;
            this.txtpaid.TextChanged += new System.EventHandler(this.txtpaid_TextChanged);
            this.txtpaid.Enter += new System.EventHandler(this.txtpaid_Enter);
            this.txtpaid.Leave += new System.EventHandler(this.txtpaid_Leave);
            // 
            // btnenter
            // 
            this.btnenter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnenter.Image = global::GNetBillingSoft.Properties.Resources.money;
            this.btnenter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnenter.Location = new System.Drawing.Point(191, 13);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(106, 50);
            this.btnenter.TabIndex = 4;
            this.btnenter.Text = "ENTER";
            this.btnenter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "BALANCE";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "PAID";
            // 
            // errorPOS
            // 
            this.errorPOS.ContainerControl = this;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 655);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPOS";
            this.Text = "POS";
            this.Activated += new System.EventHandler(this.frmPOS_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPOS_FormClosing);
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPOS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdPOS;
        private System.Windows.Forms.FlowLayoutPanel grouplayout;
        private System.Windows.Forms.FlowLayoutPanel childlayout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.Button btneight;
        private System.Windows.Forms.Button btnnine;
        private System.Windows.Forms.Button btnfour;
        private System.Windows.Forms.Button btnfive;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btnone;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnreceipt;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.TextBox txtnet;
        private System.Windows.Forms.TextBox txtdisc;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.MaskedTextBox txtphoneno;
        private System.Windows.Forms.ErrorProvider errorPOS;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txtnewbalance;
        private System.Windows.Forms.TextBox txtoldbalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btngridclear;
        private System.Windows.Forms.DomainUpDown txtinvoiceno;
        private System.Windows.Forms.Button btnunits;
        private System.Windows.Forms.TextBox txtopening;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn uprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.TextBox txtdiscamount;
        private System.Windows.Forms.MaskedTextBox txtdate;
        private System.Windows.Forms.TextBox txttokenno;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label14;
    }
}