namespace GNetBillingSoft.Reports
{
    partial class rptItemSales
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
            this.cryItemSalesView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryItemSalesView
            // 
            this.cryItemSalesView.ActiveViewIndex = -1;
            this.cryItemSalesView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryItemSalesView.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryItemSalesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryItemSalesView.Location = new System.Drawing.Point(0, 0);
            this.cryItemSalesView.Name = "cryItemSalesView";
            this.cryItemSalesView.ShowCloseButton = false;
            this.cryItemSalesView.ShowCopyButton = false;
            this.cryItemSalesView.ShowExportButton = false;
            this.cryItemSalesView.ShowGotoPageButton = false;
            this.cryItemSalesView.ShowGroupTreeButton = false;
            this.cryItemSalesView.ShowParameterPanelButton = false;
            this.cryItemSalesView.ShowTextSearchButton = false;
            this.cryItemSalesView.Size = new System.Drawing.Size(751, 404);
            this.cryItemSalesView.TabIndex = 1;
            this.cryItemSalesView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.cryItemSalesView.Load += new System.EventHandler(this.rptitemsales_Load);
            // 
            // rptItemSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 404);
            this.Controls.Add(this.cryItemSalesView);
            this.Name = "rptItemSales";
            this.Text = "Item Sales Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryItemSalesView;

    }
}