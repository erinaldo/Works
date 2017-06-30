namespace GNetBillingSoft.Reports
{
    partial class rptBankbook
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
            this.cryBankView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryBankView
            // 
            this.cryBankView.ActiveViewIndex = -1;
            this.cryBankView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryBankView.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryBankView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryBankView.Location = new System.Drawing.Point(0, 0);
            this.cryBankView.Name = "cryBankView";
            this.cryBankView.ShowCloseButton = false;
            this.cryBankView.ShowCopyButton = false;
            this.cryBankView.ShowExportButton = false;
            this.cryBankView.ShowGroupTreeButton = false;
            this.cryBankView.ShowParameterPanelButton = false;
            this.cryBankView.ShowRefreshButton = false;
            this.cryBankView.Size = new System.Drawing.Size(781, 343);
            this.cryBankView.TabIndex = 0;
            this.cryBankView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.cryBankView.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // rptBankbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 343);
            this.Controls.Add(this.cryBankView);
            this.Name = "rptBankbook";
            this.Text = "Bank Book";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryBankView;
    }
}