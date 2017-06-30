namespace GNetBillingSoft.Reports
{
    partial class frmrptLedger
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
            this.rptLedger = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptLedger
            // 
            this.rptLedger.ActiveViewIndex = -1;
            this.rptLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptLedger.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptLedger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptLedger.Location = new System.Drawing.Point(0, 0);
            this.rptLedger.Name = "rptLedger";
            this.rptLedger.ShowCloseButton = false;
            this.rptLedger.ShowCopyButton = false;
            this.rptLedger.ShowExportButton = false;
            this.rptLedger.ShowGotoPageButton = false;
            this.rptLedger.ShowGroupTreeButton = false;
            this.rptLedger.ShowParameterPanelButton = false;
            this.rptLedger.Size = new System.Drawing.Size(757, 444);
            this.rptLedger.TabIndex = 0;
            this.rptLedger.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmrptLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 444);
            this.Controls.Add(this.rptLedger);
            this.Name = "frmrptLedger";
            this.Text = "Ledger";
            this.Load += new System.EventHandler(this.frmrptLedger_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptLedger;

    }
}