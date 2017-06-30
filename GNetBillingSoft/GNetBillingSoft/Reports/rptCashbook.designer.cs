namespace GNetBillingSoft.Reports
{
    partial class rptCashbook
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
            this.cryCashBookView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            this.cryCashBookView.ActiveViewIndex = -1;
            this.cryCashBookView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryCashBookView.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryCashBookView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryCashBookView.Location = new System.Drawing.Point(0, 0);
            this.cryCashBookView.Name = "cryCashBookView";
            this.cryCashBookView.ShowCloseButton = false;
            this.cryCashBookView.ShowCopyButton = false;
            this.cryCashBookView.ShowExportButton = false;
            this.cryCashBookView.ShowGroupTreeButton = false;
            this.cryCashBookView.ShowParameterPanelButton = false;
            this.cryCashBookView.ShowRefreshButton = false;
            this.cryCashBookView.Size = new System.Drawing.Size(815, 390);
            this.cryCashBookView.TabIndex = 0;
            this.cryCashBookView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 390);
            //this.Controls.Add((System.Windows.Forms.Control)this.cryCashBookView);
            this.Controls.Add(cryCashBookView);
            this.Name = "rptCashbook";
            this.Text = "Cash Book";
            this.Load += new System.EventHandler(this.rptCashbook_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryPurchase;
    }
}