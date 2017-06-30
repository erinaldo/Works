namespace GNetBillingSoft.Master
{
    partial class frmSuplier
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdsuplier = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingbal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtopening = new System.Windows.Forms.TextBox();
            this.txtsupliername = new System.Windows.Forms.TextBox();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblOppBal = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.errorSuplier = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdsuplier)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorSuplier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdsuplier);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(291, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 269);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // grdsuplier
            // 
            this.grdsuplier.AllowUserToAddRows = false;
            this.grdsuplier.AllowUserToDeleteRows = false;
            this.grdsuplier.BackgroundColor = System.Drawing.Color.White;
            this.grdsuplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdsuplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.address,
            this.phoneno,
            this.openingbal,
            this.suplierid});
            this.grdsuplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdsuplier.Location = new System.Drawing.Point(3, 18);
            this.grdsuplier.Name = "grdsuplier";
            this.grdsuplier.ReadOnly = true;
            this.grdsuplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdsuplier.Size = new System.Drawing.Size(444, 248);
            this.grdsuplier.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "supliername";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phoneno
            // 
            this.phoneno.DataPropertyName = "phonenumber";
            this.phoneno.HeaderText = "Phone No";
            this.phoneno.Name = "phoneno";
            this.phoneno.ReadOnly = true;
            // 
            // openingbal
            // 
            this.openingbal.DataPropertyName = "openingbalance";
            this.openingbal.HeaderText = "Opp.Balance";
            this.openingbal.Name = "openingbal";
            this.openingbal.ReadOnly = true;
            // 
            // suplierid
            // 
            this.suplierid.DataPropertyName = "suplierid";
            this.suplierid.HeaderText = "suplierid";
            this.suplierid.Name = "suplierid";
            this.suplierid.ReadOnly = true;
            this.suplierid.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.txtphoneno);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtopening);
            this.groupBox1.Controls.Add(this.txtsupliername);
            this.groupBox1.Controls.Add(this.lblAddr);
            this.groupBox1.Controls.Add(this.lblOppBal);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 266);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.DarkRed;
            this.btndel.FlatAppearance.BorderSize = 0;
            this.btndel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.Location = new System.Drawing.Point(114, 225);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 33);
            this.btndel.TabIndex = 18;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(193, 225);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(71, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(33, 225);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(19, 131);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(60, 15);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone No";
            // 
            // txtphoneno
            // 
            this.txtphoneno.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneno.Location = new System.Drawing.Point(115, 128);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(149, 23);
            this.txtphoneno.TabIndex = 2;
            this.txtphoneno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(115, 54);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(149, 62);
            this.txtaddress.TabIndex = 1;
            // 
            // txtopening
            // 
            this.txtopening.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtopening.Location = new System.Drawing.Point(115, 166);
            this.txtopening.Name = "txtopening";
            this.txtopening.Size = new System.Drawing.Size(149, 23);
            this.txtopening.TabIndex = 3;
            this.txtopening.Text = "0";
            this.txtopening.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtsupliername
            // 
            this.txtsupliername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupliername.Location = new System.Drawing.Point(115, 17);
            this.txtsupliername.Name = "txtsupliername";
            this.txtsupliername.Size = new System.Drawing.Size(149, 23);
            this.txtsupliername.TabIndex = 0;
            this.txtsupliername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.Location = new System.Drawing.Point(19, 57);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(49, 15);
            this.lblAddr.TabIndex = 12;
            this.lblAddr.Text = "Address";
            // 
            // lblOppBal
            // 
            this.lblOppBal.AutoSize = true;
            this.lblOppBal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppBal.Location = new System.Drawing.Point(19, 169);
            this.lblOppBal.Name = "lblOppBal";
            this.lblOppBal.Size = new System.Drawing.Size(74, 15);
            this.lblOppBal.TabIndex = 11;
            this.lblOppBal.Text = "Opp.Balance";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(19, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // errorSuplier
            // 
            this.errorSuplier.ContainerControl = this;
            // 
            // frmSuplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSuplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suplier";
            this.Load += new System.EventHandler(this.frmSuplier_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdsuplier)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorSuplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdsuplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtopening;
        private System.Windows.Forms.TextBox txtsupliername;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblOppBal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errorSuplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingbal;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplierid;
    }
}