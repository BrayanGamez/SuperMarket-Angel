using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market_angel
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login log = new Login();
            log.FormClosed += Login_Closed;
            log.Show();
            Application.Run();
        }

        public static void Login_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= Login_Closed;
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += Login_Closed;
            }
        }

    }
}
