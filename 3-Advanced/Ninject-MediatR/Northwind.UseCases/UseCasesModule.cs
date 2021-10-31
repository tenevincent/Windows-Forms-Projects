using Ninject.Modules;
using Northwind.Ports.In;

namespace Northwind.UseCases
{
    public class UseCasesModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
        }
    }

}
