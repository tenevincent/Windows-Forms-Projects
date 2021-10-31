using Ninject.Modules;
using Northwind.Ports.In;
using Northwind.UseCases;

namespace Northwind.UI
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            //Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
         }
    }

    public class ApplicationModule2 : NinjectModule
    {
        public override void Load()
        {
             Bind(typeof(ITest)).To(typeof(TestImpl));
        }

    }

}
