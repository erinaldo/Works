using System.Windows.Forms;
using System.IO;
namespace GNetBillingSoft.DataOperation
{
    class clsnewCompSetup
    {
       public static int NavLimit = 3;
        public clsnewCompSetup()
        {
        }
        public static string  Browse()
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            string fileName = null;
            if (Directory.Exists(Application.StartupPath + "\\db"))
                dlgSave.InitialDirectory = Application.StartupPath + "\\db";
            else
            {
                Directory.CreateDirectory(Application.StartupPath + "\\db");
                dlgSave.InitialDirectory = Application.StartupPath + "\\db";
            }

            dlgSave.Filter = "MDF file |*.mdf";
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
               fileName=  dlgSave.FileName;
               clsproperties.CompanyPath = fileName;

            }
            return fileName;
        }
        public static void NavSettings(Button btn,Form frm,int count)
        {
            switch (btn.Text)
            {
                case "Next >":
                case "التالى":
                    {
                        foreach (Control ctrl in frm.Controls)
                        {
                            if (ctrl.GetType() == typeof(GroupBox))
                            {
                                if (ctrl.Name == "grpCmp" + count)
                                    ctrl.Visible = true;
                                if (ctrl.Name == "grpCmp" +( count - 1))                                    
                                    ctrl.Visible = false;
                            }
                        }
                    }
                    break;
                case "< Back ":
                    {
                        foreach (Control ctrl in frm.Controls)
                        {
                            if (ctrl.GetType() == typeof(GroupBox))
                            {
                                if (ctrl.Name == "grpCmp" + (count-1))
                                    ctrl.Visible = true;
                                if (ctrl.Name == "grpCmp" + count)
                                    ctrl.Visible = false;
                            }
                        }
                    }
                    break;
                case "Finish":
                    {

                    }
                    break;
            }
        }
        public static void HideCtrl(Form frm)
        {
            foreach (Control  ctrl in frm.Controls )
            {
                if (ctrl.GetType() == typeof(GroupBox))
                {
                    if (ctrl.Name != "grpCmp1" && ctrl.Name!="grpNav")
                    {
                        ctrl.Visible = false;
                    }
                }
            }
        }
    }
}
