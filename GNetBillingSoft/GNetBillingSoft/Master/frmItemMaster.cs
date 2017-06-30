using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
using System.IO;
namespace GNetBillingSoft.Master
{
    public partial class frmItemMaster : Form
    {
        clsitemdetails items = new clsitemdetails();
        clsperiodinfo period = new clsperiodinfo();
        clsposgroup pos = new clsposgroup();
        clsunits units = new clsunits();
        public frmItemMaster()
        {
            InitializeComponent();
            txtItemcode.Text = items.GetNextId();
            grdItems.AutoGenerateColumns = false;
            grdItems.DataSource = items.ListItems();


            txtUnit.DataSource = units.GetRecord();
            txtUnit.DisplayMember = "units";
            txtUnit.ValueMember = "units";
            if (items.ListUnit().Rows.Count == 0)
            {
                txtUnit.Text = "psc";
            }
            grdHead.AutoGenerateColumns = false;
            grdHead.DataSource = pos.GetRecord();
            DataTable dt = pos.GetRecord();
            cmbhead.DataSource = dt;
            cmbhead.DisplayMember = "itemname";
            cmbhead.ValueMember = "positemid";
            txtopening.Text = "0";

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();

        }

        private void Arabic()
        {
            //frmitemmaster fim = new frmitemmaster();
            //fim.Text = "";

            this.tabPage1.Text = "(رقم المادة(الصنف";
            this.tabPage2.Text = "مجموعة";

            //Label
            this.lblItemCode.Text = "رقم المادة";
            this.lblDescription.Text = "الوصف";
            this.lblArabic.Text = " العربى";
            this.lblGrp.Text = "مجموعة";
            this.lblUnit.Text = "الوحدة";
            this.lblBarcode.Text = "باركود";
            this.lblImg.Text = "صورة";
            this.lblPrice.Text = "السعر";
            this.lblSalesRate.Text = "معدل المبيعات";
            this.lblOppBal.Text = "الرصيد الافتتاحى";

            this.lblName.Text = "الاسم";
            this.lblGrpImg.Text = "صورة";
            
          
            //Button
            this.btnadd.Text = "إضافة";
            this.btnfontcolor.Text = "لون الخط";
            this.btnbackgroundcolor.Text = "لون الخلفية";

            this.btnGroupadd.Text = "إضافة";
            this.btnbackclr.Text = "لون الخلفية";
            

            //Grid Item
            this.itemid.HeaderText = "رقم المادة";
            this.Description.HeaderText = "الوصف";
            this.unit.HeaderText = "وحدة ";
            this.group.HeaderText = "مجموعة";

            //Grid Group
            this.slno.HeaderText = "رقم سري";
            this.name.HeaderText = "الاسم";
            this.image.HeaderText = "صورة";
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
                if (items.GetItems())
                {
                    items.ParameterizedEdit();
                }
                else
                {
                    items.ParameterizedAdd();
                    period.MaxName = "itemmaxid";
                    if (Convert.ToInt64(period.GetMaxid()) == Convert.ToInt64(items.itemid))
                    {
                        long id = Convert.ToInt64(items.itemid);
                        id++;
                        period.Maxid=id;
                        period.UpdateMaxid();
                    }
                }
                
                Clear();
            }
        }
        public bool SetData()
        {
            try
            {
                if (Validation())
                {

                    units.CheckUnits(txtUnit.Text);
                    items.itemid = txtItemcode.Text;
                    
                    items.Description = txtDescription.Text;
                    items.Unit = txtUnit.Text;
                    items.Head =Convert.ToInt64(cmbhead.SelectedValue);
                    items.actualstock = Convert.ToDouble(txtopening.Text);
                    items.ArabicDesc = txtarabic.Text;

                    items.FontColor = ColorTranslator.ToHtml(colorDlg.Color);
                    items.Backgroundcolor = ColorTranslator.ToHtml(colorbg.Color);
                    items.Barcode = txtBarcode.Text;
                    
                    if (txtsalesrate.Text != "")
                    {
                        items.salesrate =Convert.ToDouble(txtsalesrate.Text);
                    }
                    if (txtprice.Text != "")
                    {
                        items.Price= Convert.ToDouble(txtprice.Text);
                    }
                    if (File.Exists(txtchildimage.Text))
                    {

                        items.Image = File.ReadAllBytes(txtchildimage.Text);
                        items.ImgPath = txtchildimage.Text;
                    }
                    
                    return true;



                }
                return false;
            }
            catch (Exception)
            {
                return false;

            }

        }
        public bool SetGroupData()
        {
            try
            {
                if (GroupValidation())
                {

                    if (grdHead.SelectedRows.Count > 0)
                    {
                        pos.positemid = Convert.ToInt64(grdHead.Rows[grdHead.CurrentCell.RowIndex].Cells[3].Value);
                    }
                    else
                    {
                        pos.positemid = pos.GetNextId();
                    }
                    pos.itemname = txtheadname.Text;
                    pos.Backgroundcolor = ColorTranslator.ToHtml(colorbg.Color);
                    if (File.Exists(txtbackimage.Text))
                    {
                        Byte[] filebytes = File.ReadAllBytes(txtbackimage.Text);
                        pos.backimage = filebytes;
                        pos.ImagePath = txtbackimage.Text;
                    }
                    return true;



                }
                return false;
            }
            catch (Exception)
            {
                return false;

            }

        }
        private bool GroupValidation()
        {
            if (txtheadname.Text.Trim() == "")
            {
                itemmastererrors.SetError(txtItemcode, "Head name is required");
                return false;
            }
            return true;
        }
        public bool Validation()
        {
            if (txtItemcode.Text.Trim() == "")
            {
                itemmastererrors.SetError(txtItemcode, "Item Code is required");
                return false;
            }
            if (txtDescription.Text.Trim() == "")
            {
                itemmastererrors.SetError(txtDescription, "Description is required");
                return false;
            }
            if (cmbhead.SelectedValue == null)
            {
                itemmastererrors.SetError(cmbhead, "Head is required");
                return false;
            }
            if (txtUnit.Text == "")
            {
                itemmastererrors.SetError(txtUnit, "Unit is required");
                return false;
            }
            items.itemid = "";
            items.Description = txtDescription.Text;
            if (items.GetItems() && btnadd.Text!="Update")
            {
                itemmastererrors.SetError(txtDescription, "Item Already Exist");

                return false;
            }
            else
            {
                itemmastererrors.Clear();
            }
            return true;
        }
        public void Clear()
        {
            items.itemid = null;
            grdItems.DataSource = items.ListItems();
            grdItems.ClearSelection();
            grdHead.DataSource = pos.GetRecord();
            grdHead.ClearSelection();
            txtDescription.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtItemcode.Text = items.GetNextId();

            txtUnit.DataSource = units.GetRecord();
            txtUnit.DisplayMember = "units";
            txtUnit.ValueMember = "units";
            btnadd.Text = (Properties.Settings.Default.Lang == "Arabic") ? "إضافة" : " Add";
            txtheadname.Text = string.Empty;
            txtbackimage.Text = string.Empty;
            txtchildimage.Text = string.Empty;
            txtarabic.Text = string.Empty;
            txtBarcode.Text = string.Empty;
            txtsalesrate.Text = "0";
            txtprice.Text = "0";
            txtopening.Text ="0";
            btnGroupadd.Text = (Properties.Settings.Default.Lang == "Arabic") ? "إضافة" : " Add";
            colorDlg.Reset();
            colorbg.Reset();
            colorbg.Color = Color.Transparent;
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdItems_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmitemmaster_Load(object sender, EventArgs e)
        {
            grdItems.ClearSelection();
            grdItems.SelectionChanged += new EventHandler(grdItems_SelectionChanged);
        }

        void grdItems_SelectionChanged(object sender, EventArgs e)
        {
            if (grdItems.SelectedRows.Count > 0)
            {
                items.itemid = grdItems.Rows[grdItems.CurrentCell.RowIndex].Cells[0].Value.ToString();
                DataTable dt = items.ListItems();
                txtItemcode.Text = dt.Rows[0]["itemid"].ToString();
                txtDescription.Text = dt.Rows[0]["Description"].ToString();
                txtUnit.Text = dt.Rows[0]["unit"].ToString();
                txtsalesrate.Text = dt.Rows[0]["salesrate"].ToString();
                txtprice.Text = dt.Rows[0]["price"].ToString();
                txtopening.Text = (dt.Rows[0]["actualstock"].ToString()=="")?"0":dt.Rows[0]["actualstock"].ToString();
                txtchildimage.Text = dt.Rows[0]["imgpath"].ToString();
                txtarabic.Text = dt.Rows[0]["arabic_description"].ToString();
                txtBarcode.Text = dt.Rows[0]["barcode"].ToString();
                if (dt.Rows[0]["head"].ToString() != "")
                {
                    // cmbhead.SelectedIndex = Convert.ToInt32(dt.Rows[0]["head"].ToString());
                }
                btnadd.Text = (Properties.Settings.Default.Lang == "Arabic") ? "Update" : " Update";
            }
        }

        private void groupadd_Click(object sender, EventArgs e)
        {
            if (SetGroupData())
            {
                if (pos.GetItems())
                {
                    pos.ParametrizedEdit();
                }
                else
                {
                    pos.ParametirizedAdd();
                }
                
            }
            Clear();

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtbackimage.Text = dlg.FileName;
            }

        }

        private void groupclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Clear();
        }

        private void btnchildimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            dlg.FilterIndex = 2;
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtchildimage.Text = dlg.FileName;
            }
        }

        private void grdHead_SelectionChanged(object sender, EventArgs e)
        {
            if (grdHead.SelectedRows.Count != 0)
            {
                pos.positemid = Convert.ToInt64(grdHead.Rows[grdHead.CurrentCell.RowIndex].Cells[0].Value);
                DataTable dt = pos.GetSelRecord();
                txtheadname.Text = dt.Rows[0]["itemname"].ToString();
                txtbackimage.Text = dt.Rows[0]["imagepath"].ToString();
                
                //if (dt.Rows[0]["head"].ToString() != "")
                //{
                //    // cmbhead.SelectedIndex = Convert.ToInt32(dt.Rows[0]["head"].ToString());
                //}
                btnGroupadd.Text = "Update";
            }

        }

        private void grdHead_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            DataTable dt = pos.GetRecord();
            cmbhead.DataSource = dt;
            cmbhead.DisplayMember = "itemname";
            cmbhead.ValueMember = "positemid";
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void grdItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdItems.ClearSelection();
        }

        private void txtsalesrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fntDlg.ShowDialog();
        }

        private void btnfontcolor_Click(object sender, EventArgs e)
        {
            colorDlg.ShowDialog();
        }

        private void btnbackgroundcolor_Click(object sender, EventArgs e)
        {
            colorbg.ShowDialog();
        }

        private void btnbackclr_Click(object sender, EventArgs e)
        {
            colorbg.ShowDialog();
        }
    }
}
