using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft
{
    public partial class frmRemarks : Form
    {
        clsremarks remarks = new clsremarks();
        public frmRemarks()
        {
            InitializeComponent();
            CreateRemarks();
        }
        private void CreateRemarks()
        {
            DataTable dt = remarks.GetRecord();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btnremark = new Button();
                btnremark.Width = 94;
                btnremark.Height = 44;
                btnremark.Text = dt.Rows[i]["remarks"].ToString();
                btnremark.DialogResult = DialogResult.OK;
                btnremark.Click += new EventHandler(btnremark_Click);
                remarkLayout.Controls.Add(btnremark);
            }
            //remarkLayout.Height = dt.Rows.Count * 44;
            //if (dt.Rows.Count > 4)
            //{
            //    this.Height = dt.Rows.Count * 44;
            //}
        }

        void btnremark_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;
            clsproperties.Remarks = btn.Text;
        }
    }
}
