using POS_Shop.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Shop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();
            if (loginForm.IsLogin == false)
                Application.Run(loginForm);

            if (loginForm.IsLogin == true)
            {
                new FormAlertNotification().ShowAlert("Login Successfully", FormAlertNotification.Type.Success);
                Application.Run(new ParentForm());
            }
            //Application.Run(new ParentForm());

        }
    }
}
