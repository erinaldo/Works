using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;

namespace GNetBillingSoft
{
    public partial class frmunits : Form
    {
        clsunits units = new clsunits();
        public frmunits()
        {
            InitializeComponent();
            CreateUnits();
        }
        private void CreateUnits()
        {
            DataTable dt = units.GetRecord();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btnunit = new Button();
                btnunit.Width = 94;
                btnunit.Height = 44;
                btnunit.Text = dt.Rows[i]["units"].ToString();
                btnunit.Click += new EventHandler(btnunit_Click);
                btnunit.DialogResult = DialogResult.OK;
                unitLayout.Controls.Add(btnunit);
            }
            //if (dt.Rows.Count > 4)
            //{
            //    this.Height = dt.Rows.Count * 44;
            //}
        }

        void btnunit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            clsproperties.Units = btn.Text;
        }
        private void btnbox_Click(object sender, EventArgs e)
        {
            clsproperties.Units = "Box";
        }

        private void btntray_Click(object sender, EventArgs e)
        {
            clsproperties.Units = "Tray";
        }

        private void btnsp1_Click(object sender, EventArgs e)
        {
            clsproperties.Units = "SP";
            
        }

        private void btnsp2_Click(object sender, EventArgs e)
        {
            clsproperties.Units = "PKT";
        }

        private void unitLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
