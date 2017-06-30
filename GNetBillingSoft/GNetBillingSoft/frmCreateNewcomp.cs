using System;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft
{
    public partial class frmCreateNewcomp : Form
    {
        int i = 0;
        public frmCreateNewcomp()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Lang == "Arabic")
                this.Text = "إنشاء شركة جديدة";
        }

        private void frmCreateNewcomp_Load(object sender, EventArgs e)
        {
            try
            {

                clsproperties.PrgMessage = "Creating Company file Started...";
                lblProgress.Text = clsproperties.PrgMessage;
                
                if (clsDBCreator.CreateCompany())
                {
                    lblProgress.Text = "Company File Creation Completed";

                    tmrProgress.Enabled = true;
                    clsproperties.PrgMessage = "Creating Company Info...";
                }
                else
                {
                    MessageBox.Show((Properties.Settings.Default.Lang == "Arabic") ? "أخفق إنشاء الشركة" : " Company Creation Failed");
                    clsproperties.Finish = false;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void tmrProgress_Tick(object sender, EventArgs e)
        {
           
                prgCreatecmp.Value = i;

                lblProgress.Text = clsproperties.PrgMessage;
                if (!clsproperties.TableFinish)
                {

                    clsDBCreator.TableCreator(lblProgress.Text);

                    i = i + 20;
                }
                else
                    this.Close();
           
            
        }
        
        
    }
}
