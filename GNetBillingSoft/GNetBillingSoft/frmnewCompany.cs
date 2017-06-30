using System;
using System.Windows.Forms;
using System.IO;
using GNetBillingSoft.DataOperation;
using System.Text.RegularExpressions;
namespace GNetBillingSoft
{
    public partial class frmnewCompany : Form
    {
        int i = 2;
        
        public frmnewCompany()
        {
            InitializeComponent();
            clsnewCompSetup.HideCtrl(this);
            lblMessage.Text = "Congratulation ";
            lblmsg2.Text = "You have completed the required information for setting new company";
            clsproperties.TableFinish = false;

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "New Company Setup  (إعداد شركة جديدة)";
                       
            //Label
            this.lblName.Text = "اسم الشركة";
            this.lblAddr1.Text = "العنوان الأول";
            this.lblAddr2.Text = "سطر العنوان 2";
            this.lblCity.Text = "مدينة";
            this.lblzip.Text = "الرمز البريدي";
            this.lblState.Text = "حالة";
            this.lblCountry.Text = "كونتري";
            this.lblTelephone.Text = "(تليفون (ثابت";
            this.lblMobile.Text = "جوال";
            this.lblFax.Text = "عن طريق الفاكس";
            this.lblEmail.Text = "بريد اليكترونى";
         
            this.lblPeriod.Text = "";

            this.lblFrom.Text = "من";
            this.lblTo.Text = "الى";

            //this.lblMessage.Text = "";
            //this.lblmsg2.Text = "";
         

            //Button
            this.btnBack.Text = "الى الخلف";
            this.btnNext.Text = "التالى";
            this.btnHelp.Text = "مساعدة";
            this.btnCancel.Text = "إلغاء";
         

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnNext.Text == "Finish")
            {
                SetData();
                this.Close();
                clsproperties.Finish = true;
                
            }
            if (i == clsnewCompSetup.NavLimit)
            {
                clsnewCompSetup.NavSettings(btnNext, this, i);
                btnNext.Text = "Finish";
            }
            else
            {
                if (Validation())
                {
                    clsnewCompSetup.NavSettings(btnNext, this, i);
                    i++;
                }
                else
                    MessageBox.Show((Properties.Settings.Default.Lang == "Arabic") ? "الرجاء إدخال اسم الشركة .." : "Please Enter the Company Name..");
            } 
            
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtCompany.Text = clsnewCompSetup.Browse();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsnewCompSetup.NavSettings(btnBack, this,i);
            btnNext.Text = (Properties.Settings.Default.Lang == "Arabic") ? "التالى" : " Next >";
            if(i!=2)
                i--;
           
        }
        private void SetData()
        {
            try
            {
                if (Validation())
                {
                    clsproperties.DisplayName = txtCompany.Text;
                    txtCompany.Text = Regex.Replace(txtCompany.Text, "\\s", "");
                    if (File.Exists(txtCompany.Text))
                    {
                        clsproperties.CompanyPath = txtCompany.Text.Trim();

                    }
                    else
                    {
                        string path=Application.StartupPath+"\\db\\";
                        if(!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        clsproperties.CompanyPath = Application.StartupPath + "\\db\\" + txtCompany.Text;
                    }
                   
                    clsproperties.Addr1 = txtAddr1.Text;
                    clsproperties.Addr2 = txtAddr2.Text;
                    clsproperties.City = txtCity.Text;
                    clsproperties.State = txtState.Text;
                    clsproperties.Zip = txtzip.Text;
                    clsproperties.Country = txtCountry.Text;
                    clsproperties.Telephone = txtTelephone.Text;
                    clsproperties.Mobile = txtMobile.Text;
                    clsproperties.Email = txtEmail.Text;


                   

                    clsproperties.DtFrom =DateTime.ParseExact(dtFrom.Text,"dd/MM/yyyy",null);
                    clsproperties.DtTo = DateTime.ParseExact(dtTo.Text,"dd/MM/yyyy",null);



                }
                else
                    MessageBox.Show((Properties.Settings.Default.Lang == "Arabic") ? "الرجاء إدخال اسم الشركة .." : "Please Enter the Company Name..");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             String Msg = (Properties.Settings.Default.Lang == "Arabic") ? "هل تريد إلغاء إعداد الشركة الجديد" : "Do you want to cancel the New Company Setup";
             if (MessageBox.Show(Msg, "Information", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private bool Validation()
        {
            if (txtCompany.Text == "") return false;
            else return true;
        }
        
        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

       
    }
}