namespace GNetBillingSoft.Reports
{
    partial class frmLedger
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtdateTo = new System.Windows.Forms.DateTimePicker();
            this.txtdateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.rdLedger = new System.Windows.Forms.RadioButton();
            this.cmbparticulars = new System.Windows.Forms.ComboBox();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtdateTo);
            this.groupBox1.Controls.Add(this.txtdateFrom);
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Controls.Add(this.rdLedger);
            this.groupBox1.Controls.Add(this.cmbparticulars);
            this.groupBox1.Controls.Add(this.rdAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(149, 168);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(60, 28);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(78, 168);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(65, 28);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtdateTo
            // 
            this.txtdateTo.CustomFormat = "dd/MM/yyyy";
            this.txtdateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdateTo.Location = new System.Drawing.Point(78, 135);
            this.txtdateTo.Name = "txtdateTo";
            this.txtdateTo.Size = new System.Drawing.Size(131, 20);
            this.txtdateTo.TabIndex = 10;
            // 
            // txtdateFrom
            // 
            this.txtdateFrom.CustomFormat = "dd/MM/yyyy";
            this.txtdateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdateFrom.Location = new System.Drawing.Point(78, 101);
            this.txtdateFrom.Name = "txtdateFrom";
            this.txtdateFrom.Size = new System.Drawing.Size(131, 20);
            this.txtdateFrom.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(19, 134);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 15);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(19, 103);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(36, 15);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.Text = "From";
            // 
            // rdLedger
            // 
            this.rdLedger.AutoSize = true;
            this.rdLedger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rdLedger.Location = new System.Drawing.Point(22, 33);
            this.rdLedger.Name = "rdLedger";
            this.rdLedger.Size = new System.Drawing.Size(64, 19);
            this.rdLedger.TabIndex = 6;
            this.rdLedger.TabStop = true;
            this.rdLedger.Text = "Ledger";
            this.rdLedger.UseVisualStyleBackColor = true;
            this.rdLedger.CheckedChanged += new System.EventHandler(this.rdLedger_CheckedChanged);
            // 
            // cmbparticulars
            // 
            this.cmbparticulars.FormattingEnabled = true;
            this.cmbparticulars.Location = new System.Drawing.Point(22, 61);
            this.cmbparticulars.Name = "cmbparticulars";
            this.cmbparticulars.Size = new System.Drawing.Size(187, 21);
            this.cmbparticulars.TabIndex = 5;
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rdAll.Location = new System.Drawing.Point(22, 11);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(39, 19);
            this.rdAll.TabIndex = 4;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "All";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // frmLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(258, 217);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmLedger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ledger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker txtdateTo;
        private System.Windows.Forms.DateTimePicker txtdateFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.RadioButton rdLedger;
        private System.Windows.Forms.ComboBox cmbparticulars;
        private System.Windows.Forms.RadioButton rdAll;
    }
}