using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestingKeypad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerKeypad1_ButtonPressed(object sender, KeyPressEventArgs e)
        {
            textBox1.Text += e.KeyChar;
        }
    }
}
