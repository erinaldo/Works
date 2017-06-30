using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Reports
{
    public partial class frmItemSales : Form
    {
        clsposgroup group = new clsposgroup();
        clsitemdetails item = new clsitemdetails();
        clsperiodinfo period = new clsperiodinfo();
        public frmItemSales()
        {
            InitializeComponent();
            DataTable dt = period.GetRecord();
            dtFrom.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            dtFrom.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            dtTo.MinDate = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            dtTo.MaxDate = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());

            string from = DateTime.Now.ToString("dd/MM/yyyy");
            string to = DateTime.Now.ToString("dd/MM/yyyy");
            dtFrom.Value = Convert.ToDateTime(from);
            dtTo.Value = Convert.ToDateTime(to);
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtTo.CustomFormat = "dd/MM/yyyy";
            //dtFrom.Value = Convert.ToDateTime(dt.Rows[0]["periodstart"].ToString());
            //dtTo.Value = Convert.ToDateTime(dt.Rows[0]["periodend"].ToString());
            DataTable dtgroup = group.GetRecord();
            DataRow dr = dtgroup.NewRow();
            dr["itemname"] = "All";
            dr["positemid"] = 0;
            dtgroup.Rows.Add(dr);
            dtgroup.DefaultView.Sort = "positemid";
            cmbgroup.DataSource = dtgroup;
            cmbgroup.DisplayMember = "itemname";
            cmbgroup.ValueMember = "positemid";

            DataTable dtitem = item.GetRecord();
            DataRow dr1 = dtitem.NewRow();
            dr1["Description"] = "All";
            dr1["itemid"] = 0;
            dtitem.Rows.Add(dr1);
            dtitem.DefaultView.Sort = "itemid";
            cmbitems.DataSource = dtitem;
            cmbitems.DisplayMember = "Description";
            cmbitems.ValueMember = "itemid";

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "تقرير مبيعات البند";

            this.lblGroup.Text = "مجموعة";
            this.lblItems.Text = "(رقم المادة(الصنف";
            lblFrom.Text = "من";
            lblTo.Text = "الى";

            btnshow.Text = "عرض";
            btnclose.Text = "اقفال";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            rptItemSales frm = new rptItemSales();
            frm.MdiParent = this.MdiParent;
            frm.from = dtFrom.Value;
            frm.to = dtTo.Value;
            frm.timefrom = timefrom.Value;
            frm.timeto = timeto.Value;
            frm.group = Convert.ToInt64(cmbgroup.SelectedValue.ToString());
            frm.item = Convert.ToInt64(cmbitems.SelectedValue.ToString());
            
            frm.Show();
        }

        private void cmbgroup_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbgroup.SelectedIndex!=0)
            {
                item.Head = cmbgroup.SelectedIndex;
                DataTable dt = item.GetSelRecord();
                DataRow dr1 = dt.NewRow();
                dr1["Description"] = "All";
                dr1["itemid"] = 0;
                dt.Rows.Add(dr1);
                dt.DefaultView.Sort = "itemid";
                cmbitems.DataSource = dt;
                cmbitems.DisplayMember = "Description";
                cmbitems.ValueMember = "itemid";
            }
            else if (cmbgroup.SelectedIndex == 0)
            {
                DataTable dtitem = item.GetRecord();
                DataRow dr1 = dtitem.NewRow();
                dr1["Description"] = "All";
                dr1["itemid"] = 0;
                dtitem.Rows.Add(dr1);
                dtitem.DefaultView.Sort = "itemid";
                cmbitems.DataSource = dtitem;
                cmbitems.DisplayMember = "Description";
                cmbitems.ValueMember = "itemid";
            }
        }

        
    }
}
