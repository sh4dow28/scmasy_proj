using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScMaSy_ice
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Form StartupFM = new Form();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // if (Properties.Settings.Default.isFirstTime == true) { StartupFM = new FM_Main(); }
            // else { StartupFM = new Views.FirstStartupConfig.FM_DBConfig(); }
            Application.Run(new Views.LoginView());
        }
    }
}
