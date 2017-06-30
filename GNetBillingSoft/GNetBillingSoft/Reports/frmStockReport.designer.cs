namespace GNetBillingSoft.Reports
{
    partial class frmStockReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdStock = new System.Windows.Forms.DataGridView();
            this.slno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesrate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualstock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.differenceamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnmainclose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdStock
            // 
            this.grdStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdStock.BackgroundColor = System.Drawing.Color.White;
            this.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slno,
            this.code,
            this.name,
            this.Unit,
            this.quantity,
            this.cost,
            this.total,
            this.salesrate,
            this.stotal,
            this.actualstock,
            this.difference,
            this.differenceamount,
            this.totalcost});
            this.grdStock.Location = new System.Drawing.Point(6, 19);
            this.grdStock.Name = "grdStock";
            this.grdStock.Size = new System.Drawing.Size(945, 338);
            this.grdStock.TabIndex = 0;
            // 
            // slno
            // 
            this.slno.DataPropertyName = "slno";
            this.slno.FillWeight = 10F;
            this.slno.HeaderText = "SlNo";
            this.slno.Name = "slno";
            this.slno.ReadOnly = true;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.FillWeight = 15F;
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 88.19854F;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // Unit
            // 
            this.Unit.FillWeight = 15F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.quantity.FillWeight = 23F;
            this.quantity.HeaderText = "Current Stock";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.cost.DefaultCellStyle = dataGridViewCellStyle2;
            this.cost.FillWeight = 20F;
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            // 
            // total
            // 
            this.total.DataPropertyName = "totalcost";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle3;
            this.total.FillWeight = 20F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // salesrate
            // 
            this.salesrate.DataPropertyName = "salesrate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.salesrate.DefaultCellStyle = dataGridViewCellStyle4;
            this.salesrate.FillWeight = 90F;
            this.salesrate.HeaderText = "Sale Price";
            this.salesrate.Name = "salesrate";
            this.salesrate.Visible = false;
            // 
            // stotal
            // 
            this.stotal.DataPropertyName = "totalsales";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.stotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.stotal.FillWeight = 10F;
            this.stotal.HeaderText = "Total";
            this.stotal.Name = "stotal";
            this.stotal.ReadOnly = true;
            this.stotal.Visible = false;
            // 
            // actualstock
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.actualstock.DefaultCellStyle = dataGridViewCellStyle6;
            this.actualstock.HeaderText = "Stock Counted";
            this.actualstock.Name = "actualstock";
            this.actualstock.Visible = false;
            // 
            // difference
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.difference.DefaultCellStyle = dataGridViewCellStyle7;
            this.difference.HeaderText = "Difference";
            this.difference.Name = "difference";
            this.difference.Visible = false;
            // 
            // differenceamount
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.differenceamount.DefaultCellStyle = dataGridViewCellStyle8;
            this.differenceamount.HeaderText = "DIFF-AMT";
            this.differenceamount.Name = "differenceamount";
            this.differenceamount.Visible = false;
            // 
            // totalcost
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.totalcost.DefaultCellStyle = dataGridViewCellStyle9;
            this.totalcost.HeaderText = "Total Cost";
            this.totalcost.Name = "totalcost";
            this.totalcost.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(821, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnmainclose
            // 
            this.btnmainclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnmainclose.FlatAppearance.BorderSize = 0;
            this.btnmainclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmainclose.ForeColor = System.Drawing.Color.White;
            this.btnmainclose.Location = new System.Drawing.Point(890, 395);
            this.btnmainclose.Name = "btnmainclose";
            this.btnmainclose.Size = new System.Drawing.Size(65, 30);
            this.btnmainclose.TabIndex = 21;
            this.btnmainclose.Text = "Close";
            this.btnmainclose.UseVisualStyleBackColor = false;
            this.btnmainclose.Click += new System.EventHandler(this.btnmainclose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdStock);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 377);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnmainclose);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.Name = "frmStockReport";
            this.Text = "Stock Report";
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnmainclose;
        private System.Windows.Forms.DataGridViewTextBoxColumn slno;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesrate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn differenceamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcost;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}