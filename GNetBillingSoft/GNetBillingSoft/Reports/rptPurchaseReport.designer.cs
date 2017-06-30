namespace GNetBillingSoft
{
    partial class rptPurchaseReport
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
            this.rptviewPurReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptviewPurReport
            // 
            this.rptviewPurReport.ActiveViewIndex = -1;
            this.rptviewPurReport.AutoSize = true;
            this.rptviewPurReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptviewPurReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptviewPurReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptviewPurReport.Location = new System.Drawing.Point(0, 0);
            this.rptviewPurReport.Name = "rptviewPurReport";
            this.rptviewPurReport.ShowCloseButton = false;
            this.rptviewPurReport.ShowCopyButton = false;
            this.rptviewPurReport.ShowExportButton = false;
            this.rptviewPurReport.ShowGroupTreeButton = false;
            this.rptviewPurReport.ShowParameterPanelButton = false;
            this.rptviewPurReport.ShowRefreshButton = false;
            this.rptviewPurReport.ShowTextSearchButton = false;
            this.rptviewPurReport.Size = new System.Drawing.Size(787, 305);
            this.rptviewPurReport.TabIndex = 0;
            this.rptviewPurReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptpurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 305);
            this.Controls.Add(this.rptviewPurReport);
            this.Name = "rptpurchaseReport";
            this.Text = "Purchase Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptpurchaseReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptviewPurReport;
    }
}