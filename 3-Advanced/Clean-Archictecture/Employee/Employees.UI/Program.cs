using Core;
using System;
using System.Windows.Forms;

namespace Employees.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            IocContainer.Instance.Init();
            IocContainer.Instance.InitMapper();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(IocContainer.Instance.Resolve<MainForm>());
        }


    }
}
