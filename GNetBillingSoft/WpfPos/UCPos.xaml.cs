using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.Integration;

namespace WpfUserControl
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UCPos : UserControl
    {
        //private System.Windows.Forms.Integration.ElementHost elhostUserControl11;
        //private WpfUserControl.UCPos objUCPos;
        
       // public Button btnChkOt;


        public UCPos()
        {
            InitializeComponent();
           // btnChkOt = btnCheckOut;
        }

        private void btnCheckOut_Click(object sender, RoutedEventArgs e)
        {          
        
            ////// Within InitializeComponent
            //this.elhostUserControl11 = new System.Windows.Forms.Integration.ElementHost();
            //Form1 myParent = (Form1)this.Parent;
            //frmNewPos d = new (frmNewPos)this.Parent;
            ////this.wpfUserControl = new WPFUserControl.WPFUserControl();

            //frmNewPos frm;     //frm_main is your main form which user control is on it
            //frm=(frmNewPos)this.FindForm(); 

            //Form parentForm = (this.Parent);
            ((this.Parent) as Window).Content = new UCPos();
        }
    }
}
