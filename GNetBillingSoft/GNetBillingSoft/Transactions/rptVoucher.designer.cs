namespace GNetBillingSoft.Transactions
{
    partial class rptVoucher
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
            this.cryVoucher = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryVoucher
            // 
            this.cryVoucher.ActiveViewIndex = -1;
            this.cryVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryVoucher.EnableRefresh = false;
            this.cryVoucher.Location = new System.Drawing.Point(0, 0);
            this.cryVoucher.Name = "cryVoucher";
            this.cryVoucher.ShowCloseButton = false;
            this.cryVoucher.ShowCopyButton = false;
            this.cryVoucher.ShowExportButton = false;
            this.cryVoucher.ShowGroupTreeButton = false;
            this.cryVoucher.ShowParameterPanelButton = false;
            this.cryVoucher.ShowRefreshButton = false;
            this.cryVoucher.ShowTextSearchButton = false;
            this.cryVoucher.Size = new System.Drawing.Size(778, 361);
            this.cryVoucher.TabIndex = 0;
            this.cryVoucher.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptvoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 361);
            this.Controls.Add(this.cryVoucher);
            this.Name = "rptvoucher";
            this.Text = "Voucher";
            this.Load += new System.EventHandler(this.rptvoucher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryVoucher;
    }
}