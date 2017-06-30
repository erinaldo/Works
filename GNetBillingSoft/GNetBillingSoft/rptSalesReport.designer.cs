namespace GNetBillingSoft
{
    partial class frmviewsalesreport
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
            this.crySalesReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crySalesReport
            // 
            this.crySalesReport.ActiveViewIndex = -1;
            this.crySalesReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crySalesReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crySalesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crySalesReport.Location = new System.Drawing.Point(0, 0);
            this.crySalesReport.Name = "crySalesReport";
            this.crySalesReport.ShowCloseButton = false;
            this.crySalesReport.ShowCopyButton = false;
            this.crySalesReport.ShowGroupTreeButton = false;
            this.crySalesReport.ShowParameterPanelButton = false;
            this.crySalesReport.ShowRefreshButton = false;
            this.crySalesReport.ShowTextSearchButton = false;
            this.crySalesReport.Size = new System.Drawing.Size(805, 362);
            this.crySalesReport.TabIndex = 0;
            this.crySalesReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmviewsalesreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 362);
            this.Controls.Add(this.crySalesReport);
            this.Name = "frmviewsalesreport";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.frmviewsalesreport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crySalesReport;
    }
}