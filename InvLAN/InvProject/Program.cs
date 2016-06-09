using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvProject
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
            DialogResult result;
            using (var loginForm = new Login())
                result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // login was successful
                Application.Run(new MainView());
            }
        }
    }
}
