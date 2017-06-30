namespace GNetBillingSoft.Reports
{
    partial class rptCashTray
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
            this.cryCrashReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryCrashReport
            // 
            this.cryCrashReport.ActiveViewIndex = -1;
            this.cryCrashReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryCrashReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryCrashReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryCrashReport.Location = new System.Drawing.Point(0, 0);
            this.cryCrashReport.Name = "cryCrashReport";
            this.cryCrashReport.ShowCloseButton = false;
            this.cryCrashReport.ShowCopyButton = false;
            this.cryCrashReport.ShowGroupTreeButton = false;
            this.cryCrashReport.ShowParameterPanelButton = false;
            this.cryCrashReport.ShowRefreshButton = false;
            this.cryCrashReport.ShowTextSearchButton = false;
            this.cryCrashReport.Size = new System.Drawing.Size(693, 415);
            this.cryCrashReport.TabIndex = 1;
            this.cryCrashReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmcashtrayrpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 415);
            this.Controls.Add(this.cryCrashReport);
            this.Name = "frmcashtrayrpt";
            this.Text = "Cash Tray Report";
            this.Load += new System.EventHandler(this.frmcashtrayrpt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryCrashReport;
    }
}