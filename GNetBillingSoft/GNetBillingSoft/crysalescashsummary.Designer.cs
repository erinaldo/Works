namespace GNetBillingSoft
{
    partial class cryReportviewer
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
            this.cryviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryviewer
            // 
            this.cryviewer.ActiveViewIndex = -1;
            this.cryviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryviewer.Location = new System.Drawing.Point(0, 0);
            this.cryviewer.Name = "cryviewer";
            this.cryviewer.ShowCloseButton = false;
            this.cryviewer.ShowCopyButton = false;
            this.cryviewer.ShowExportButton = false;
            this.cryviewer.ShowGroupTreeButton = false;
            this.cryviewer.ShowParameterPanelButton = false;
            this.cryviewer.ShowRefreshButton = false;
            this.cryviewer.Size = new System.Drawing.Size(733, 387);
            this.cryviewer.TabIndex = 1;
            this.cryviewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.cryviewer.Load += new System.EventHandler(this.cryviewer_Load);
            // 
            // cryReportviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 387);
            this.Controls.Add(this.cryviewer);
            this.Name = "cryReportviewer";
            this.Text = "Sales and Cash Summary";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryviewer;
    }
}