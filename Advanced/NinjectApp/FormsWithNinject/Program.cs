using Ninject;
using Northwind.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
     

            IocContainer.Instance.LoadModule(new ApplicationModule());
         

            IocContainer.Instance.Kernel.Load(new ApplicationModule2());


            Application.Run(IocContainer.Instance.Resolve<MainForm>());



        }
    }
}
