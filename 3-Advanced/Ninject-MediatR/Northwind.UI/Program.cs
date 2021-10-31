using MediatR;
using MediatR.Pipeline;
using Ninject;
using Ninject.Planning.Bindings.Resolvers;
using Northwind.Root;
using System;
using MediatR.Pipeline;

using System.Windows.Forms;
using Northwind.UseCases;

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


            IocContainer.Instance.InitMediatR();
            IocContainer.Instance.LoadModule(new ApplicationModule());
            IocContainer.Instance.LoadModule(new UseCasesModule());

            
            IocContainer.Instance. Kernel.Load(new ApplicationModule2());         

            Application.Run(IocContainer.Instance.Resolve<MainForm>());



        }
    }
}
