namespace GNetBillingSoft
{
    partial class frmSalesReport
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtfrom = new System.Windows.Forms.DateTimePicker();
            this.txtto = new System.Windows.Forms.DateTimePicker();
            this.timefrom = new System.Windows.Forms.DateTimePicker();
            this.timeto = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(11, 27);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(35, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            this.lblFrom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(11, 68);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 15);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            this.lblTo.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(148, 123);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 33);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(228, 123);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 33);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtfrom
            // 
            this.txtfrom.CustomFormat = "dd/MM/yyyy";
            this.txtfrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfrom.Location = new System.Drawing.Point(53, 21);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(166, 23);
            this.txtfrom.TabIndex = 6;
            this.txtfrom.ValueChanged += new System.EventHandler(this.txtfrom_ValueChanged);
            // 
            // txtto
            // 
            this.txtto.CustomFormat = "dd/MM/yyyy";
            this.txtto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtto.Location = new System.Drawing.Point(53, 62);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(166, 23);
            this.txtto.TabIndex = 7;
            this.txtto.ValueChanged += new System.EventHandler(this.txtto_ValueChanged);
            // 
            // timefrom
            // 
            this.timefrom.CustomFormat = "hh:mm tt ";
            this.timefrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timefrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timefrom.Location = new System.Drawing.Point(228, 21);
            this.timefrom.Name = "timefrom";
            this.timefrom.ShowUpDown = true;
            this.timefrom.Size = new System.Drawing.Size(76, 23);
            this.timefrom.TabIndex = 9;
            this.timefrom.Value = new System.DateTime(2014, 6, 4, 0, 0, 0, 0);
            this.timefrom.ValueChanged += new System.EventHandler(this.timefrom_ValueChanged);
            // 
            // timeto
            // 
            this.timeto.CustomFormat = "hh:mm tt";
            this.timeto.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeto.Location = new System.Drawing.Point(228, 62);
            this.timeto.Name = "timeto";
            this.timeto.ShowUpDown = true;
            this.timeto.Size = new System.Drawing.Size(76, 23);
            this.timeto.TabIndex = 10;
            this.timeto.Value = new System.DateTime(2014, 6, 4, 23, 59, 0, 0);
            this.timeto.ValueChanged += new System.EventHandler(this.timeto_ValueChanged);
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 182);
            this.Controls.Add(this.timefrom);
            this.Controls.Add(this.timeto);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DateTimePicker txtfrom;
        private System.Windows.Forms.DateTimePicker txtto;
        private System.Windows.Forms.DateTimePicker timefrom;
        private System.Windows.Forms.DateTimePicker timeto;
    }
}