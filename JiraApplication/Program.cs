using System;
using System.Windows.Forms;
using JiraApplication.Views;

namespace JiraApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //IKernel kernel
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
