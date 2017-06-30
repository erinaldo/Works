using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft
{
    public partial class frmOpenCmp : Form
    {
        public frmOpenCmp()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "فتح الشركة";

            btnOpen.Text = "فتح";
            btnCancel.Text = "إلغاء";
            btnDelete.Text = "الغاء";
            btnbackup.Text = "اسناد او النسخ الاحتياطى";
            btnRestore.Text = "يعيد او يجدد";

            this.chkdefault.Text = "تعيين الشركة الافتراضية";
        }
        private void frmOpenCmp_Load(object sender, EventArgs e)
        {
            
            DataTable dt= dboperation.RetrieveCompany();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["database_name"].ToString() != "master" && dt.Rows[i]["database_name"].ToString() != "model" && dt.Rows[i]["database_name"].ToString() != "msdb" && dt.Rows[i]["database_name"].ToString() != "tempdb")
                {
                    lstCompany.Items.Add(dt.Rows[i]["database_name"]);
                }

            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (lstCompany.SelectedIndex!=-1)
            {
                clsproperties.CompanyName = lstCompany.SelectedItem.ToString();
                dboperation.SetServerConnection(chkdefault.Checked);
                this.Close();

                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "هل تريد حقا حذف الشركة" : "Do you really want delete the company";
            if (MessageBox.Show(Msg, "Delete Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsDBCreator.DropTable(lstCompany.SelectedItem.ToString()))
                {
                    int index = lstCompany.SelectedIndex;
                    lstCompany.Items.RemoveAt(index);
                }
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            string companyname = lstCompany.SelectedItem.ToString();
            String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "هل تريد أن تأخذ النسخ الاحتياطي" : "Do you want to take Backup";
            if (DialogResult.Yes == MessageBox.Show(Msg, "Backup", MessageBoxButtons.YesNo))
            {
                clsDBCreator.Backup(companyname);
            }
        }
        

        private void btnRestore_Click(object sender, EventArgs e)
        {
            dlgOpen.Filter = "Back Up(*.bak)|*.bak";
            DialogResult dlg=dlgOpen.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                clsDBCreator.Restore(dlgOpen);
            }
            
        }

        /*private void btnReset_Click(object sender, EventArgs e)
        {
            
            string companyname = lstCompany.SelectedItem.ToString();
            DialogResult s = MessageBox.Show("Do you really want to reset " + companyname + ".","Warning", MessageBoxButtons.YesNo);
            if (s == DialogResult.Yes)
            {
                if (DialogResult.Yes==MessageBox.Show("Do you want to take Backup", "Backup", MessageBoxButtons.YesNo))
                {
                    clsDBCreator.Backup(companyname);
                }
            }
        }*/
    }
}
