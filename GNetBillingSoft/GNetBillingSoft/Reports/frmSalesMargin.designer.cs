namespace GNetBillingSoft.Reports
{
    partial class frmSalesMargin
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdinvoicewise = new System.Windows.Forms.RadioButton();
            this.rddaywise = new System.Windows.Forms.RadioButton();
            this.rdItemwise = new System.Windows.Forms.RadioButton();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.dsReport = new GNetBillingSoft.dsReport();
            this.salesmarginreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesmarginTableAdapter = new GNetBillingSoft.dsReportTableAdapters.salesmarginTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmarginreportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(17, 26);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(35, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(17, 55);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 15);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "dd/MM/yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(99, 20);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(143, 23);
            this.dtFrom.TabIndex = 2;
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "dd/MM/yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(99, 49);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(143, 23);
            this.dtTo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdinvoicewise);
            this.groupBox2.Controls.Add(this.rddaywise);
            this.groupBox2.Controls.Add(this.rdItemwise);
            this.groupBox2.Controls.Add(this.cmbItem);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // rdinvoicewise
            // 
            this.rdinvoicewise.AutoSize = true;
            this.rdinvoicewise.Location = new System.Drawing.Point(20, 100);
            this.rdinvoicewise.Name = "rdinvoicewise";
            this.rdinvoicewise.Size = new System.Drawing.Size(92, 19);
            this.rdinvoicewise.TabIndex = 5;
            this.rdinvoicewise.TabStop = true;
            this.rdinvoicewise.Tag = "invwise";
            this.rdinvoicewise.Text = "Invoice Wise";
            this.rdinvoicewise.UseVisualStyleBackColor = true;
            this.rdinvoicewise.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // rddaywise
            // 
            this.rddaywise.AutoSize = true;
            this.rddaywise.Location = new System.Drawing.Point(20, 62);
            this.rddaywise.Name = "rddaywise";
            this.rddaywise.Size = new System.Drawing.Size(75, 19);
            this.rddaywise.TabIndex = 4;
            this.rddaywise.Tag = "daywise";
            this.rddaywise.Text = "Day Wise";
            this.rddaywise.UseVisualStyleBackColor = true;
            this.rddaywise.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // rdItemwise
            // 
            this.rdItemwise.AutoSize = true;
            this.rdItemwise.Checked = true;
            this.rdItemwise.Location = new System.Drawing.Point(20, 18);
            this.rdItemwise.Name = "rdItemwise";
            this.rdItemwise.Size = new System.Drawing.Size(78, 19);
            this.rdItemwise.TabIndex = 3;
            this.rdItemwise.TabStop = true;
            this.rdItemwise.Tag = "Itemwise";
            this.rdItemwise.Text = "Item Wise";
            this.rdItemwise.UseVisualStyleBackColor = true;
            this.rdItemwise.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(99, 17);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(143, 23);
            this.cmbItem.TabIndex = 2;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Green;
            this.btnshow.FlatAppearance.BorderSize = 0;
            this.btnshow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.ForeColor = System.Drawing.Color.White;
            this.btnshow.Location = new System.Drawing.Point(111, 247);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 30);
            this.btnshow.TabIndex = 6;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(192, 247);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 30);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dsReport
            // 
            this.dsReport.DataSetName = "dsReport";
            this.dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesmarginreportBindingSource
            // 
            this.salesmarginreportBindingSource.DataMember = "salesmarginreport";
            this.salesmarginreportBindingSource.DataSource = this.dsReport;
            // 
            // salesmarginTableAdapter
            // 
            this.salesmarginTableAdapter.ClearBeforeFill = true;
            // 
            // frmSalesMargin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(279, 285);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSalesMargin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Margin Report";
            this.Load += new System.EventHandler(this.frmSalesMargin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmarginreportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.BindingSource salesmarginreportBindingSource;
        private dsReport dsReport;
        private dsReportTableAdapters.salesmarginTableAdapter salesmarginTableAdapter;
        private System.Windows.Forms.RadioButton rddaywise;
        private System.Windows.Forms.RadioButton rdItemwise;
        private System.Windows.Forms.RadioButton rdinvoicewise;
    }
}