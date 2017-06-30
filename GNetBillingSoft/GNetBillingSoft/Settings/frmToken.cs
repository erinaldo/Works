using System;
using System.Data;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
namespace GNetBillingSoft.Settings
{
    public partial class frmToken : Form
    {
        clstokensettings tokensetting = new clstokensettings();
        public frmToken()
        {
            InitializeComponent();
            AddSelRecord();

            if (Properties.Settings.Default.Lang == "Arabic")
                Arabic();
        }

        private void Arabic()
        {
            this.Text = "إعدادات الرمز المميز";

            //Labels

            this.lblStrt.Text = "بداية";
            this.lblEnd.Text = "النهاية";
            
            //groupbox

            this.grpBoxTime.Text = "زمن";
            this.grpBoxNum.Text = "رقم البدء";

            //Button
            this.btnsave.Text = "حفظ";
            this.btnclose.Text = "اقفال";
            this.btnreset.Text = "إعادة تعيين";

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (SetData())
            {
                if (tokensetting.GetItems())
                {
                    tokensetting.Edit();
                }
                else
                {
                    tokensetting.Add();
                }
                MessageBox.Show((Properties.Settings.Default.Lang == "Arabic") ? "تم حفظ إعدادات الرموز المميزة" : "Token Settings Saved");
                Clear();
            }
        }
        private bool SetData()
        {
            try
            {
                tokensetting.tokenid =(txttokenid.Text!="")?Convert.ToInt64(txttokenid.Text): tokensetting.GetNextId();
                tokensetting.tokenstarttime = dtstart.Value;
                tokensetting.tokenendtime = dtend.Value;
                tokensetting.tokenstartnumber = (txtstartingnumber.Text != "") ? Convert.ToDouble(txtstartingnumber.Text) : 0;
                tokensetting.addeddate = DateTime.Now;
                tokensetting.addedby = clsuserinfo.UID;
                tokensetting.CurrentToken = (txtstartingnumber.Text != "") ? Convert.ToInt64(txtstartingnumber.Text) : 0;
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
        private void Clear()
        {

            AddSelRecord();


        }
        private void AddSelRecord()
        {
            DataTable dt = tokensetting.GetRecord();
            if (dt.Rows.Count > 0)
            {
                txtstartingnumber.Text = dt.Rows[0]["tokenstartnumber"].ToString();
                dtstart.Value = Convert.ToDateTime(dt.Rows[0]["tokenstarttime"].ToString());
                dtend.Value = Convert.ToDateTime(dt.Rows[0]["tokenendtime"].ToString());
                txttokenid.Text = dt.Rows[0]["tokenid"].ToString();
                lblcurrenttoken.Text = dt.Rows[0]["currenttoken"].ToString();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            if (txttokenid.Text != "")
            {
                if (SetData())
                {
                    if (tokensetting.GetItems())
                    {
                        tokensetting.Edit();
                        AddSelRecord();
                    }
                }
            }
        }
    }
}
