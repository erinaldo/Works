using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using WpfUserControl;

namespace GNetBillingSoft
{
    public partial class frmNewPOS : Form
    {
        public frmNewPOS()
        {

            InitializeComponent();

            WpfUserControl.UCPos var1 = new WpfUserControl.UCPos();
            //var1..Content = "af";
            
        }
    }
}
