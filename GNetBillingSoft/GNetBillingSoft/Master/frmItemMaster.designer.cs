namespace GNetBillingSoft.Master
{
    partial class frmItemMaster
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
            this.itemmastererrors = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnbackgroundcolor = new System.Windows.Forms.Button();
            this.btnfontcolor = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtopening = new System.Windows.Forms.TextBox();
            this.lblOppBal = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtsalesrate = new System.Windows.Forms.TextBox();
            this.lblSalesRate = new System.Windows.Forms.Label();
            this.grdItems = new System.Windows.Forms.DataGridView();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblArabic = new System.Windows.Forms.Label();
            this.txtarabic = new System.Windows.Forms.TextBox();
            this.btnchildimage = new System.Windows.Forms.Button();
            this.txtchildimage = new System.Windows.Forms.TextBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.cmbhead = new System.Windows.Forms.ComboBox();
            this.lblGrp = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtItemcode = new System.Windows.Forms.TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnbackclr = new System.Windows.Forms.Button();
            this.grdHead = new System.Windows.Forms.DataGridView();
            this.slno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.positemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGroupadd = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.txtbackimage = new System.Windows.Forms.TextBox();
            this.lblGrpImg = new System.Windows.Forms.Label();
            this.txtheadname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.fntDlg = new System.Windows.Forms.FontDialog();
            this.colorDlg = new System.Windows.Forms.ColorDialog();
            this.colorbg = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.itemmastererrors)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHead)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemmastererrors
            // 
            this.itemmastererrors.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 410);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnadd);
            this.tabPage1.Controls.Add(this.btnbackgroundcolor);
            this.tabPage1.Controls.Add(this.btnfontcolor);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.grdItems);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Green;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(599, 344);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(92, 33);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnbackgroundcolor
            // 
            this.btnbackgroundcolor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbackgroundcolor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnbackgroundcolor.ForeColor = System.Drawing.Color.White;
            this.btnbackgroundcolor.Location = new System.Drawing.Point(396, 266);
            this.btnbackgroundcolor.Name = "btnbackgroundcolor";
            this.btnbackgroundcolor.Size = new System.Drawing.Size(120, 28);
            this.btnbackgroundcolor.TabIndex = 12;
            this.btnbackgroundcolor.Text = "Background Color";
            this.btnbackgroundcolor.UseVisualStyleBackColor = false;
            this.btnbackgroundcolor.Click += new System.EventHandler(this.btnbackgroundcolor_Click);
            // 
            // btnfontcolor
            // 
            this.btnfontcolor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnfontcolor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnfontcolor.ForeColor = System.Drawing.Color.White;
            this.btnfontcolor.Location = new System.Drawing.Point(315, 266);
            this.btnfontcolor.Name = "btnfontcolor";
            this.btnfontcolor.Size = new System.Drawing.Size(75, 28);
            this.btnfontcolor.TabIndex = 11;
            this.btnfontcolor.Text = "Font Color";
            this.btnfontcolor.UseVisualStyleBackColor = false;
            this.btnfontcolor.Click += new System.EventHandler(this.btnfontcolor_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtopening);
            this.groupBox5.Controls.Add(this.lblOppBal);
            this.groupBox5.Controls.Add(this.txtprice);
            this.groupBox5.Controls.Add(this.lblPrice);
            this.groupBox5.Controls.Add(this.txtsalesrate);
            this.groupBox5.Controls.Add(this.lblSalesRate);
            this.groupBox5.Location = new System.Drawing.Point(3, 252);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 118);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // txtopening
            // 
            this.txtopening.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopening.Location = new System.Drawing.Point(114, 85);
            this.txtopening.Name = "txtopening";
            this.txtopening.Size = new System.Drawing.Size(154, 23);
            this.txtopening.TabIndex = 10;
            this.txtopening.Text = "0";
            this.txtopening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblOppBal
            // 
            this.lblOppBal.AutoSize = true;
            this.lblOppBal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOppBal.Location = new System.Drawing.Point(8, 92);
            this.lblOppBal.Name = "lblOppBal";
            this.lblOppBal.Size = new System.Drawing.Size(100, 15);
            this.lblOppBal.TabIndex = 8;
            this.lblOppBal.Text = "Opening Balance";
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(114, 19);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(154, 23);
            this.txtprice.TabIndex = 8;
            this.txtprice.Text = "0";
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(9, 22);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // txtsalesrate
            // 
            this.txtsalesrate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalesrate.Location = new System.Drawing.Point(114, 53);
            this.txtsalesrate.Name = "txtsalesrate";
            this.txtsalesrate.Size = new System.Drawing.Size(154, 23);
            this.txtsalesrate.TabIndex = 9;
            this.txtsalesrate.Text = "0";
            this.txtsalesrate.TextChanged += new System.EventHandler(this.txtsalesrate_TextChanged);
            this.txtsalesrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblSalesRate
            // 
            this.lblSalesRate.AutoSize = true;
            this.lblSalesRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalesRate.Location = new System.Drawing.Point(9, 56);
            this.lblSalesRate.Name = "lblSalesRate";
            this.lblSalesRate.Size = new System.Drawing.Size(64, 15);
            this.lblSalesRate.TabIndex = 0;
            this.lblSalesRate.Text = "Sales Rate";
            // 
            // grdItems
            // 
            this.grdItems.AllowUserToAddRows = false;
            this.grdItems.AllowUserToDeleteRows = false;
            this.grdItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdItems.BackgroundColor = System.Drawing.Color.White;
            this.grdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemid,
            this.Description,
            this.unit,
            this.group});
            this.grdItems.Location = new System.Drawing.Point(315, 7);
            this.grdItems.Name = "grdItems";
            this.grdItems.ReadOnly = true;
            this.grdItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItems.Size = new System.Drawing.Size(376, 247);
            this.grdItems.TabIndex = 11;
            this.grdItems.TabStop = false;
            this.grdItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdItems_DataBindingComplete);
            // 
            // itemid
            // 
            this.itemid.DataPropertyName = "itemid";
            this.itemid.FillWeight = 83.83455F;
            this.itemid.HeaderText = "Code";
            this.itemid.Name = "itemid";
            this.itemid.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 162.4366F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.FillWeight = 44.38308F;
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // group
            // 
            this.group.DataPropertyName = "itemname";
            this.group.FillWeight = 109.3458F;
            this.group.HeaderText = "Group";
            this.group.Name = "group";
            this.group.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBarcode);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.lblArabic);
            this.groupBox1.Controls.Add(this.txtarabic);
            this.groupBox1.Controls.Add(this.btnchildimage);
            this.groupBox1.Controls.Add(this.txtchildimage);
            this.groupBox1.Controls.Add(this.lblImg);
            this.groupBox1.Controls.Add(this.cmbhead);
            this.groupBox1.Controls.Add(this.lblGrp);
            this.groupBox1.Controls.Add(this.txtUnit);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtItemcode);
            this.groupBox1.Controls.Add(this.lblItemCode);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location = new System.Drawing.Point(8, 192);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(53, 15);
            this.lblBarcode.TabIndex = 20;
            this.lblBarcode.Text = "Barcode";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(76, 189);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(192, 23);
            this.txtBarcode.TabIndex = 6;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblArabic
            // 
            this.lblArabic.AutoSize = true;
            this.lblArabic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblArabic.Location = new System.Drawing.Point(8, 97);
            this.lblArabic.Name = "lblArabic";
            this.lblArabic.Size = new System.Drawing.Size(42, 15);
            this.lblArabic.TabIndex = 18;
            this.lblArabic.Text = "Arabic";
            // 
            // txtarabic
            // 
            this.txtarabic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarabic.Location = new System.Drawing.Point(76, 94);
            this.txtarabic.Name = "txtarabic";
            this.txtarabic.Size = new System.Drawing.Size(192, 23);
            this.txtarabic.TabIndex = 3;
            this.txtarabic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // btnchildimage
            // 
            this.btnchildimage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchildimage.Location = new System.Drawing.Point(245, 215);
            this.btnchildimage.Name = "btnchildimage";
            this.btnchildimage.Size = new System.Drawing.Size(24, 23);
            this.btnchildimage.TabIndex = 16;
            this.btnchildimage.Text = "---";
            this.btnchildimage.UseVisualStyleBackColor = true;
            this.btnchildimage.Click += new System.EventHandler(this.btnchildimage_Click);
            // 
            // txtchildimage
            // 
            this.txtchildimage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchildimage.Location = new System.Drawing.Point(76, 217);
            this.txtchildimage.Name = "txtchildimage";
            this.txtchildimage.Size = new System.Drawing.Size(162, 23);
            this.txtchildimage.TabIndex = 7;
            this.txtchildimage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblImg.Location = new System.Drawing.Point(9, 220);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(42, 15);
            this.lblImg.TabIndex = 14;
            this.lblImg.Text = "Image";
            // 
            // cmbhead
            // 
            this.cmbhead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhead.FormattingEnabled = true;
            this.cmbhead.Location = new System.Drawing.Point(76, 122);
            this.cmbhead.Name = "cmbhead";
            this.cmbhead.Size = new System.Drawing.Size(192, 23);
            this.cmbhead.TabIndex = 4;
            this.cmbhead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblGrp
            // 
            this.lblGrp.AutoSize = true;
            this.lblGrp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGrp.Location = new System.Drawing.Point(8, 125);
            this.lblGrp.Name = "lblGrp";
            this.lblGrp.Size = new System.Drawing.Size(42, 15);
            this.lblGrp.TabIndex = 12;
            this.lblGrp.Text = "Group";
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.FormattingEnabled = true;
            this.txtUnit.Items.AddRange(new object[] {
            "psc"});
            this.txtUnit.Location = new System.Drawing.Point(76, 160);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(192, 23);
            this.txtUnit.TabIndex = 5;
            this.txtUnit.Text = "psc";
            this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(8, 163);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(31, 15);
            this.lblUnit.TabIndex = 10;
            this.lblUnit.Text = "Unit";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(8, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(71, 15);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(76, 66);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 23);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtItemcode
            // 
            this.txtItemcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemcode.Location = new System.Drawing.Point(76, 29);
            this.txtItemcode.Name = "txtItemcode";
            this.txtItemcode.Size = new System.Drawing.Size(192, 23);
            this.txtItemcode.TabIndex = 1;
            this.txtItemcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemCode.Location = new System.Drawing.Point(8, 32);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(65, 15);
            this.lblItemCode.TabIndex = 6;
            this.lblItemCode.Text = "Item Code";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnbackclr);
            this.tabPage2.Controls.Add(this.grdHead);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(701, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Group ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnbackclr
            // 
            this.btnbackclr.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnbackclr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnbackclr.ForeColor = System.Drawing.Color.White;
            this.btnbackclr.Location = new System.Drawing.Point(545, 261);
            this.btnbackclr.Name = "btnbackclr";
            this.btnbackclr.Size = new System.Drawing.Size(146, 27);
            this.btnbackclr.TabIndex = 20;
            this.btnbackclr.Text = "Background Color";
            this.btnbackclr.UseVisualStyleBackColor = false;
            this.btnbackclr.Click += new System.EventHandler(this.btnbackclr_Click);
            // 
            // grdHead
            // 
            this.grdHead.AllowUserToAddRows = false;
            this.grdHead.AllowUserToDeleteRows = false;
            this.grdHead.BackgroundColor = System.Drawing.Color.White;
            this.grdHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slno,
            this.name,
            this.image,
            this.positemid});
            this.grdHead.Location = new System.Drawing.Point(349, 6);
            this.grdHead.Name = "grdHead";
            this.grdHead.ReadOnly = true;
            this.grdHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHead.Size = new System.Drawing.Size(342, 249);
            this.grdHead.TabIndex = 2;
            this.grdHead.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdHead_DataError);
            this.grdHead.SelectionChanged += new System.EventHandler(this.grdHead_SelectionChanged);
            // 
            // slno
            // 
            this.slno.DataPropertyName = "positemid";
            this.slno.FillWeight = 30F;
            this.slno.HeaderText = "SlNo";
            this.slno.Name = "slno";
            this.slno.ReadOnly = true;
            this.slno.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "itemname";
            this.name.HeaderText = "Head / Group";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.DataPropertyName = "backimage";
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // positemid
            // 
            this.positemid.DataPropertyName = "positemid";
            this.positemid.HeaderText = "positemid";
            this.positemid.Name = "positemid";
            this.positemid.ReadOnly = true;
            this.positemid.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGroupadd);
            this.groupBox3.Controls.Add(this.btnbrowse);
            this.groupBox3.Controls.Add(this.txtbackimage);
            this.groupBox3.Controls.Add(this.lblGrpImg);
            this.groupBox3.Controls.Add(this.txtheadname);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 249);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnGroupadd
            // 
            this.btnGroupadd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGroupadd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGroupadd.FlatAppearance.BorderSize = 0;
            this.btnGroupadd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupadd.ForeColor = System.Drawing.Color.White;
            this.btnGroupadd.Location = new System.Drawing.Point(210, 107);
            this.btnGroupadd.Name = "btnGroupadd";
            this.btnGroupadd.Size = new System.Drawing.Size(81, 31);
            this.btnGroupadd.TabIndex = 0;
            this.btnGroupadd.Text = "Add";
            this.btnGroupadd.UseVisualStyleBackColor = false;
            this.btnGroupadd.Click += new System.EventHandler(this.groupadd_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.BackColor = System.Drawing.Color.White;
            this.btnbrowse.BackgroundImage = global::GNetBillingSoft.Properties.Resources.search_icon_hi;
            this.btnbrowse.FlatAppearance.BorderSize = 0;
            this.btnbrowse.ForeColor = System.Drawing.Color.White;
            this.btnbrowse.Location = new System.Drawing.Point(297, 62);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(35, 30);
            this.btnbrowse.TabIndex = 4;
            this.btnbrowse.Text = "---";
            this.btnbrowse.UseVisualStyleBackColor = false;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtbackimage
            // 
            this.txtbackimage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbackimage.Location = new System.Drawing.Point(67, 64);
            this.txtbackimage.Name = "txtbackimage";
            this.txtbackimage.Size = new System.Drawing.Size(224, 25);
            this.txtbackimage.TabIndex = 3;
            // 
            // lblGrpImg
            // 
            this.lblGrpImg.AutoSize = true;
            this.lblGrpImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGrpImg.Location = new System.Drawing.Point(17, 64);
            this.lblGrpImg.Name = "lblGrpImg";
            this.lblGrpImg.Size = new System.Drawing.Size(42, 15);
            this.lblGrpImg.TabIndex = 2;
            this.lblGrpImg.Text = "Image";
            // 
            // txtheadname
            // 
            this.txtheadname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtheadname.Location = new System.Drawing.Point(67, 29);
            this.txtheadname.Name = "txtheadname";
            this.txtheadname.Size = new System.Drawing.Size(224, 25);
            this.txtheadname.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(17, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // fntDlg
            // 
            this.fntDlg.Color = System.Drawing.SystemColors.ControlText;
            // 
            // colorbg
            // 
            this.colorbg.Color = System.Drawing.Color.Transparent;
            // 
            // frmItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 402);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmItemMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Master";
            this.Load += new System.EventHandler(this.frmitemmaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemmastererrors)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdHead)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider itemmastererrors;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grdItems;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGrp;
        private System.Windows.Forms.ComboBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtItemcode;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGroupadd;
        private System.Windows.Forms.DataGridView grdHead;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox txtbackimage;
        private System.Windows.Forms.Label lblGrpImg;
        private System.Windows.Forms.TextBox txtheadname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbhead;
        private System.Windows.Forms.Button btnchildimage;
        private System.Windows.Forms.TextBox txtchildimage;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtsalesrate;
        private System.Windows.Forms.Label lblSalesRate;
        private System.Windows.Forms.TextBox txtopening;
        private System.Windows.Forms.Label lblOppBal;
        private System.Windows.Forms.FontDialog fntDlg;
        private System.Windows.Forms.ColorDialog colorDlg;
        private System.Windows.Forms.Label lblArabic;
        private System.Windows.Forms.TextBox txtarabic;
        private System.Windows.Forms.Button btnfontcolor;
        private System.Windows.Forms.Button btnbackgroundcolor;
        private System.Windows.Forms.ColorDialog colorbg;
        private System.Windows.Forms.Button btnbackclr;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn slno;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn positemid;

    }
}