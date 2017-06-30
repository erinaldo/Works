using System.Windows.Forms;

namespace ClassModule
{
    class clsCreateMenu
    {
        public clsCreateMenu()
        {
        }
        public static   void CreateMenu(Form  frm,string User)
        {
            switch (User)
            {
                case "Admin":
                    {
                        foreach (Control  ctrl in frm.Controls )
                        {
                            if (ctrl.GetType() == typeof(MenuStrip))
                            {
                                ctrl.Visible = true;

                            }
                        }
                    }
                    break;
            }
           
        }

    }
}
