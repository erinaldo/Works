namespace GNetBillingSoft.Transactions
{
    partial class rptSalesInvoice
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
            this.cryReceipt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptreceipt1 = new GNetBillingSoft.rptreceipt();
            this.SuspendLayout();
            // 
            // cryReceipt
            // 
            this.cryReceipt.ActiveViewIndex = -1;
            this.cryReceipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryReceipt.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryReceipt.Location = new System.Drawing.Point(0, 0);
            this.cryReceipt.Name = "cryReceipt";
            this.cryReceipt.ReuseParameterValuesOnRefresh = true;
            this.cryReceipt.ShowCloseButton = false;
            this.cryReceipt.ShowCopyButton = false;
            this.cryReceipt.ShowExportButton = false;
            this.cryReceipt.ShowGroupTreeButton = false;
            this.cryReceipt.ShowParameterPanelButton = false;
            this.cryReceipt.ShowRefreshButton = false;
            this.cryReceipt.ShowTextSearchButton = false;
            this.cryReceipt.Size = new System.Drawing.Size(856, 389);
            this.cryReceipt.TabIndex = 0;
            this.cryReceipt.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptsalesinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 389);
            this.Controls.Add(this.cryReceipt);
            this.Name = "rptsalesinvoice";
            this.Text = "Sales Invoice";
            this.Load += new System.EventHandler(this.frmreceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryReceipt;
        private rptreceipt rptreceipt1;

    }
}