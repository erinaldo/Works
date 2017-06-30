using System;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft
{
    public partial class frmLogin : Form
    {
        clsuserinfo user = new clsuserinfo();
        clsuserroles role = new clsuserroles();
        mainmdi frmmain = new mainmdi();
        MenuStrip mainmenu;
        public frmLogin(MenuStrip mnu)
        {
            InitializeComponent();
            mainmenu = mnu;
            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "Login  (تسجيل الدخول)";

            lblAccLogin.Text = "تسجل الدخول";
            lblUsrName.Text = "اسم المستخدم";
            lblPswd.Text = "كلمه السر";
            btLogin.Text = "تسجيل الدخول";
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

        private void btnok_Click(object sender, EventArgs e)
        {
            user.username = txtusername.Text;
            user.password = txtPassword.Text;
            long userid = 0;
            clsUpgrade.UpdateAdminPassword();
            if (user.CheckUserInfo(ref userid))
            {
                //frmmain.MenuDefault(true);

                this.Close();
                clsUpgrade.Upgrade();
                clsuserroles.UId = userid;
                clsuserinfo.UID = userid;
            }
            else
            {
                MessageBox.Show((Properties.Settings.Default.Lang == "Arabic") ? "خطأ في اسم المستخدم أو كلمة مرور" : "Invalid Username or Password");
                DialogResult = DialogResult.None;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //frmmain.MenuDefault(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //frmmain.MenuDefault(false);
            dboperation.ClearConnection();
            this.Close();
        }
    }
}
