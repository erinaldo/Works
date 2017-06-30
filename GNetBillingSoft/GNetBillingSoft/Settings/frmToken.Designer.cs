namespace GNetBillingSoft.Settings
{
    partial class frmToken
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
            this.grpBoxTime = new System.Windows.Forms.GroupBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtend = new System.Windows.Forms.DateTimePicker();
            this.lblStrt = new System.Windows.Forms.Label();
            this.dtstart = new System.Windows.Forms.DateTimePicker();
            this.grpBoxNum = new System.Windows.Forms.GroupBox();
            this.txtstartingnumber = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblcurrenttoken = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.txttokenid = new System.Windows.Forms.TextBox();
            this.grpBoxTime.SuspendLayout();
            this.grpBoxNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxTime
            // 
            this.grpBoxTime.Controls.Add(this.lblEnd);
            this.grpBoxTime.Controls.Add(this.dtend);
            this.grpBoxTime.Controls.Add(this.lblStrt);
            this.grpBoxTime.Controls.Add(this.dtstart);
            this.grpBoxTime.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTime.Location = new System.Drawing.Point(12, 0);
            this.grpBoxTime.Name = "grpBoxTime";
            this.grpBoxTime.Size = new System.Drawing.Size(129, 100);
            this.grpBoxTime.TabIndex = 0;
            this.grpBoxTime.TabStop = false;
            this.grpBoxTime.Text = "Time";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(12, 54);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 3;
            this.lblEnd.Text = "End";
            // 
            // dtend
            // 
            this.dtend.CustomFormat = "hh:mm tt";
            this.dtend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtend.Location = new System.Drawing.Point(47, 51);
            this.dtend.Name = "dtend";
            this.dtend.ShowUpDown = true;
            this.dtend.Size = new System.Drawing.Size(69, 22);
            this.dtend.TabIndex = 2;
            this.dtend.Value = new System.DateTime(2016, 3, 13, 0, 0, 0, 0);
            // 
            // lblStrt
            // 
            this.lblStrt.AutoSize = true;
            this.lblStrt.Location = new System.Drawing.Point(12, 28);
            this.lblStrt.Name = "lblStrt";
            this.lblStrt.Size = new System.Drawing.Size(31, 13);
            this.lblStrt.TabIndex = 1;
            this.lblStrt.Text = "Start";
            // 
            // dtstart
            // 
            this.dtstart.CustomFormat = "hh:mm tt";
            this.dtstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtstart.Location = new System.Drawing.Point(47, 25);
            this.dtstart.Name = "dtstart";
            this.dtstart.ShowUpDown = true;
            this.dtstart.Size = new System.Drawing.Size(69, 22);
            this.dtstart.TabIndex = 0;
            this.dtstart.Value = new System.DateTime(2016, 3, 13, 1, 0, 0, 0);
            // 
            // grpBoxNum
            // 
            this.grpBoxNum.Controls.Add(this.txtstartingnumber);
            this.grpBoxNum.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxNum.Location = new System.Drawing.Point(150, 2);
            this.grpBoxNum.Name = "grpBoxNum";
            this.grpBoxNum.Size = new System.Drawing.Size(129, 54);
            this.grpBoxNum.TabIndex = 1;
            this.grpBoxNum.TabStop = false;
            this.grpBoxNum.Text = "Starting Number";
            // 
            // txtstartingnumber
            // 
            this.txtstartingnumber.Location = new System.Drawing.Point(6, 19);
            this.txtstartingnumber.Name = "txtstartingnumber";
            this.txtstartingnumber.Size = new System.Drawing.Size(100, 22);
            this.txtstartingnumber.TabIndex = 0;
            this.txtstartingnumber.Text = "100";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(73, 175);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(156, 175);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblcurrenttoken
            // 
            this.lblcurrenttoken.AutoSize = true;
            this.lblcurrenttoken.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrenttoken.Location = new System.Drawing.Point(153, 67);
            this.lblcurrenttoken.Name = "lblcurrenttoken";
            this.lblcurrenttoken.Size = new System.Drawing.Size(25, 13);
            this.lblcurrenttoken.TabIndex = 3;
            this.lblcurrenttoken.Text = "100";
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(220, 62);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(54, 23);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txttokenid
            // 
            this.txttokenid.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttokenid.Location = new System.Drawing.Point(12, 106);
            this.txttokenid.Name = "txttokenid";
            this.txttokenid.Size = new System.Drawing.Size(129, 22);
            this.txttokenid.TabIndex = 5;
            this.txttokenid.Visible = false;
            // 
            // frmtoken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 201);
            this.Controls.Add(this.txttokenid);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.lblcurrenttoken);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.grpBoxNum);
            this.Controls.Add(this.grpBoxTime);
            this.MaximizeBox = false;
            this.Name = "frmtoken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token Settings";
            this.grpBoxTime.ResumeLayout(false);
            this.grpBoxTime.PerformLayout();
            this.grpBoxNum.ResumeLayout(false);
            this.grpBoxNum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTime;
        private System.Windows.Forms.Label lblStrt;
        private System.Windows.Forms.DateTimePicker dtstart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtend;
        private System.Windows.Forms.GroupBox grpBoxNum;
        private System.Windows.Forms.TextBox txtstartingnumber;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblcurrenttoken;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txttokenid;
    }
}