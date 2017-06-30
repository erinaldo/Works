namespace GNetBillingSoft
{
    partial class rptPOSReport
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
            this.cryPOSView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryPOSView
            // 
            this.cryPOSView.ActiveViewIndex = -1;
            this.cryPOSView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryPOSView.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryPOSView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryPOSView.Location = new System.Drawing.Point(0, 0);
            this.cryPOSView.Name = "cryPOSView";
            this.cryPOSView.ShowCloseButton = false;
            this.cryPOSView.ShowCopyButton = false;
            this.cryPOSView.ShowExportButton = false;
            this.cryPOSView.ShowGotoPageButton = false;
            this.cryPOSView.ShowGroupTreeButton = false;
            this.cryPOSView.ShowParameterPanelButton = false;
            this.cryPOSView.Size = new System.Drawing.Size(738, 305);
            this.cryPOSView.TabIndex = 0;
            this.cryPOSView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmposreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 305);
            this.Controls.Add(this.cryPOSView);
            this.Name = "frmposreport";
            this.Text = "POS Report";
            this.Load += new System.EventHandler(this.frmposreport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryPOSView;
    }
}