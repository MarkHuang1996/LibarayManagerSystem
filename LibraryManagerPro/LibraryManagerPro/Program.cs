using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace LibraryManagerPro
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
            //Create Login Form
            FmAdminLogin fmLogin = new FmAdminLogin();
            DialogResult result = fmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                Application.Run(new FmMain());
            }
            else
            {
                Application.Exit();
            }

       
        }
        public static SysAdmin objCurrentAdmin = null;

    }
}

