// Type: GNetBillingSoft.frmviewsalesmargin
// Assembly: GNetBillingSoft, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF94799A-7D18-4F06-8215-9E1CC70A2A54
// Assembly location: F:\jdownloads\GNetBillingSoft\GNetBillingSoft.exe

using CrystalDecisions.Windows.Forms;
using GNetBillingSoft.dsReportTableAdapters;

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GNetBillingSoft.Reports
{
  partial class frmviewsalesmargin 
  {
    private IContainer components = (IContainer) null;
    
    
    

    

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.salesmarginreportBindingSource = new BindingSource(this.components);
      this.dsReport = new dsReport();
      //this.salesmarginTableAdapter = new salesmarginTableAdapter();
      this.rptsalesmargin = new CrystalReportViewer();
     // this.salesmarginreportBindingSource.BeginInit();
      this.dsReport.BeginInit();
      this.SuspendLayout();
      this.salesmarginreportBindingSource.DataMember = "salesmarginreport";
      this.salesmarginreportBindingSource.DataSource = (object) this.dsReport;
      this.dsReport.DataSetName = "dsReport";
      this.dsReport.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
     // this.salesmarginTableAdapter.ClearBeforeFill = true;
      this.rptsalesmargin.ActiveViewIndex = -1;
      this.rptsalesmargin.BorderStyle = BorderStyle.FixedSingle;
      this.rptsalesmargin.Cursor = Cursors.Default;
      this.rptsalesmargin.Dock = DockStyle.Fill;
      this.rptsalesmargin.Location = new Point(0, 0);
      this.rptsalesmargin.Name = "rptsalesmargin";
      this.rptsalesmargin.ShowCloseButton = false;
      this.rptsalesmargin.ShowCopyButton = false;
      this.rptsalesmargin.ShowExportButton = false;
      this.rptsalesmargin.ShowGotoPageButton = false;
      this.rptsalesmargin.ShowGroupTreeButton = false;
      this.rptsalesmargin.ShowParameterPanelButton = false;
      this.rptsalesmargin.ShowTextSearchButton = false;
      this.rptsalesmargin.Size = new Size(714, 447);
      this.rptsalesmargin.TabIndex = 0;
      this.rptsalesmargin.ToolPanelView = ToolPanelViewType.None;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(714, 447);
      this.Controls.Add((Control) this.rptsalesmargin);
      this.Name = "frmviewsalesmargin";
      this.Text = "Sales Margin";
      this.Load += new EventHandler(this.frmviewsalesmargin_Load);
    //  this.salesmarginreportBindingSource.EndInit();
      this.dsReport.EndInit();
      this.ResumeLayout(false);
    }

    
  }
}
