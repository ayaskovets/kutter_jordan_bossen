using System;
using System.Windows.Forms;

using KutterJordanBossen.IoC;

namespace KutterJordanBossenForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutofacConfig.RegisterDependencies();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
