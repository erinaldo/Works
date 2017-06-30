using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GNetBillingSoft.DataOperation;
using System.IO;
namespace GNetBillingSoft
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            dboperation db = new dboperation();
            //MessageBox.Show(Properties.Settings.Default.daysused.ToString());
            string filename = Application.StartupPath + "\\GNetBillingSoft.exe";
            DateTime createddate = File.GetCreationTime(filename);
            DateTime todaydate = DateTime.Now;
            DateTime expirydate = Convert.ToDateTime("2017-03-31");
            TimeSpan diff = expirydate-todaydate;
            int limit = 90;
            int totaldays = diff.Days;
            int trial = (limit - totaldays);
            bool expired = false;
            //if (totaldays>0 && totaldays <= 7)
            //{
            //    MessageBox.Show("Expiry after " + totaldays + " days", "Trial Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else if (totaldays <= 0)
            //{
            //    MessageBox.Show("Trial period expired...", "Trial Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    expired = true;
            //}
            
            //if (trial ==0)
            //{
            //    MessageBox.Show("Trial period expired...","Trial Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}
                //MessageBox.Show("This is a trial version. This software expire after " + trial + " days", "Trial Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (!expired)
            {
                Properties.Settings.Default.daysused = Properties.Settings.Default.daysused + 1;
                Properties.Settings.Default.Save();
                // MessageBox.Show(Properties.Settings.Default.daysused.ToString());
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new mainmdi());
            }
            
            
           
        }
    }
}
