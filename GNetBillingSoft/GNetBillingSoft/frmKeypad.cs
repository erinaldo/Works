using System;
using System.Windows.Forms;

namespace GNetBillingSoft
{
    public partial class frmKeypad : Form
    {
        //Control focus;
        private Control mvarcontrol;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams para = base.CreateParams;
        //        para.ExStyle |= 0x08000000;
        //        return para;
        //    }
        //}
        public frmKeypad()
        {
            InitializeComponent();
            
        }

        private void action_click(object sender, EventArgs e)
        {
            try
            {
            _Focused.Focus();
            
            Button btn = (Button)sender;
            SendKeys.Send(btn.Text);
                }
            catch(Exception)
            {
            }

        }
        public Control _Focused
        {
            get
            {
                return mvarcontrol;
            }
            set
            {
                mvarcontrol=value;
            }
        }


    }
}
