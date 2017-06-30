using GNetBillingSoft.DataOperation;
using System;
using System.Data;
using System.Windows.Forms;

namespace GNetBillingSoft
{
    public partial class frmOpnRmt : Form
    {
        public frmOpnRmt()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "(أوبين كومباني (ريموت";

            lblServer.Text = "الخادم";

            btnOpen.Text = "فتح";
            btnCancel.Text = "إلغاء";
            btnConnect.Text = "الاتصال";

            this.chkdefault.Text = "تعيين الشركة الافتراضية";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lstCompany.SelectedIndex != -1)
            {
                clsproperties.CompanyName = lstCompany.SelectedItem.ToString();
                dboperation.SetServerConnection(chkdefault.Checked);
                this.Close();


            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            clsproperties.IPAddress = txtServer.Text;
            DataTable dt = dboperation.RetrieveCompany();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["database_name"].ToString() != "master" && dt.Rows[i]["database_name"].ToString() != "model" && dt.Rows[i]["database_name"].ToString() != "msdb" && dt.Rows[i]["database_name"].ToString() != "tempdb")
                {
                    lstCompany.Items.Add(dt.Rows[i]["database_name"]);
                }

            }
        }
    }
}
