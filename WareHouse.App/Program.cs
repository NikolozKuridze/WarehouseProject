using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.App.Dialogs;

namespace WareHouse.App
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
            bool isLogged = false;
            using(LoginForm login=new LoginForm())
            {
                isLogged = login.ShowDialog() == DialogResult.OK;
            }
            if (isLogged)
            {
                Application.Run(new MainForm());
            }
        }
  }
}
