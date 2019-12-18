using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Downloader
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
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            System.Windows.Forms.Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.Run(new Form1());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            
        }
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
        }
    }
}
