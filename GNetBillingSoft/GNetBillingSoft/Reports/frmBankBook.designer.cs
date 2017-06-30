// Type: GNetBillingSoft.frmBankBook
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GNetBillingSoft.Reports
{
  partial  class frmBankBook 
  {
    private IContainer components = (IContainer) null;
    private DateTimePicker txtto;
    private DateTimePicker txtfrom;
    private Button btnclose;
    private Button btnShow;
    private Label lblTo;
    private Label lblfrom;

    

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.txtto = new System.Windows.Forms.DateTimePicker();
            this.txtfrom = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblfrom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtto
            // 
            this.txtto.CustomFormat = "dd/MM/yyyy";
            this.txtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtto.Location = new System.Drawing.Point(60, 61);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(200, 20);
            this.txtto.TabIndex = 19;
            // 
            // txtfrom
            // 
            this.txtfrom.CustomFormat = "dd/MM/yyyy";
            this.txtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtfrom.Location = new System.Drawing.Point(60, 20);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(200, 20);
            this.txtfrom.TabIndex = 18;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(185, 109);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 36);
            this.btnclose.TabIndex = 17;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Green;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(104, 109);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 36);
            this.btnShow.TabIndex = 16;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(18, 65);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(21, 15);
            this.lblTo.TabIndex = 15;
            this.lblTo.Text = "To";
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.Location = new System.Drawing.Point(18, 23);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(36, 15);
            this.lblfrom.TabIndex = 14;
            this.lblfrom.Text = "From";
            // 
            // frmBankBook
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(278, 157);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblfrom);
            this.MaximizeBox = false;
            this.Name = "frmBankBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Book";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    
  }
}
