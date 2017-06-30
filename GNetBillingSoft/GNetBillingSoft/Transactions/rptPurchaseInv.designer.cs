namespace GNetBillingSoft.Transactions
{
    partial class rptPurchaseInv
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
            this.cryPurchase = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryPurchase
            // 
            this.cryPurchase.ActiveViewIndex = -1;
            this.cryPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryPurchase.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryPurchase.Location = new System.Drawing.Point(0, 0);
            this.cryPurchase.Name = "cryPurchase";
            this.cryPurchase.ShowCloseButton = false;
            this.cryPurchase.ShowCopyButton = false;
            this.cryPurchase.ShowExportButton = false;
            this.cryPurchase.ShowGroupTreeButton = false;
            this.cryPurchase.ShowParameterPanelButton = false;
            this.cryPurchase.ShowRefreshButton = false;
            this.cryPurchase.ShowTextSearchButton = false;
            this.cryPurchase.Size = new System.Drawing.Size(826, 460);
            this.cryPurchase.TabIndex = 0;
            this.cryPurchase.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptpurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 460);
            this.Controls.Add(this.cryPurchase);
            this.Name = "rptpurchase";
            this.Text = " Purchase Report";
            this.Load += new System.EventHandler(this.rptpurchase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryPurchase;
    }
}