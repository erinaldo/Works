using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Master
{
    public partial class frmUnits_Remarks : Form
    {
        clsunits units = new clsunits();
        clsremarks remark=new clsremarks();
        public frmUnits_Remarks()
        {
            InitializeComponent();
            UnitRecord();
            RemarkRecord();

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
            
        }

        private void Arabic()
        {
            this.Text = "وحدات وملاحظات";

            //Labels
            this.lblQnty.Text = "وحدة ";
            this.lblRmrk.Text = "ملاحظات";
            this.lblUnit.Text = "وحدة ";

            //button
            this.btnunit.Text = "حفظ";
            this.btnremarks.Text = "حفظ";

            //Data grid
            this.unitname.HeaderText = "الوحدة";
            this.quantity.HeaderText = "الكمية";

            this.remarkid.HeaderText = "رقم سري";
            this.remarks.HeaderText = "ملاحظات";
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (e.KeyChar == '\r')
                    if (this.ActiveControl != null)
                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void btnunit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                units.unitid =(txtunitid.Text=="")? units.GetNextId():Convert.ToInt64(txtunitid.Text);
                units.units = txtUnitname.Text;
                units.quantity = Convert.ToDouble(txtquantity.Text);
                if (units.GetItems())
                {
                    units.Edit();
                }
                else
                {
                    units.Add();
                }
                UnitRecord();
                Clear();
            }
        }
        private bool Validation()
        {
            if (txtUnitname.Text.Trim() == "")
            {
                errUnits.SetError(txtUnitname, "Unit Name is Required");
                return false;
            }
            if (txtquantity.Text.Trim() == "")
            {
                errUnits.SetError(txtquantity, "Quantity is Required");
                return false;
            }
            return true;
        }
        private void Clear()
        {
            UnitRecord();
            RemarkRecord();
            txtUnitname.Text = string.Empty;
            txtquantity.Text = string.Empty;
            txtunitid.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            txtremarkid.Text = string.Empty;
            btnremarks.Text = "Save";
            btnunit.Text = "Save";
            
        }
        private void UnitRecord()
        {
             grdUnits.DataSource = units.GetRecord();
             grdUnits.ClearSelection();

        }

        private void grdUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (grdUnits.SelectedRows.Count > 0)
            {
                units.unitid =Convert.ToInt64(grdUnits.CurrentRow.Cells[0].Value);
                DataTable dt = units.GetSelRecord();
                if (dt.Rows.Count > 0)
                {
                    txtunitid.Text = dt.Rows[0]["unitid"].ToString();
                    txtUnitname.Text = dt.Rows[0]["units"].ToString();
                    txtquantity.Text = dt.Rows[0]["quantity"].ToString();
                    btnunit.Text = "Update";
                }
            }
        }

        private void frmUnits_Remarkmaster_Load(object sender, EventArgs e)
        {
            grdUnits.ClearSelection();
            grdUnits.SelectionChanged+=new EventHandler(grdUnits_SelectionChanged);
            
           
        }

        void grdRemarks_SelectionChanged(object sender, EventArgs e)
        {
            if (grdRemarks.SelectedRows.Count > 0)
            {
                try
                {
                    remark.remarkid = Convert.ToInt64(grdRemarks.CurrentRow.Cells[0].Value);
                    DataTable dt = remark.GetSelRecord();
                    if (dt.Rows.Count > 0)
                    {
                        txtremarkid.Text = dt.Rows[0]["remarkid"].ToString();
                        txtRemarks.Text = dt.Rows[0]["remarks"].ToString();
                        btnremarks.Text = "Update";
                    }
                }
                catch (Exception )
                {
                }
            }
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            //Clear();
          
        }

        private void btnremarks_Click(object sender, EventArgs e)
        {
            if (ValidateRemarks())
            {
                remark.remarkid = (txtremarkid.Text == "") ? remark.GetNextId() : Convert.ToInt64(txtremarkid.Text);
                remark.remarks = txtRemarks.Text;
                if (remark.GetItems())
                {
                    remark.Edit();
                }
                else
                {
                    remark.Add();
                }
                RemarkRecord();
                Clear();
            }
        }
        private bool ValidateRemarks()
        {
            if (txtRemarks.Text.Trim() == "")
            {
                errUnits.SetError(txtRemarks, "Remarks is Required");
                return false;
            }
            return true;
        }
        private void RemarkRecord()
        {
            grdRemarks.AutoGenerateColumns = false;
            grdRemarks.DataSource = remark.GetRecord();
            grdRemarks.ClearSelection();
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
