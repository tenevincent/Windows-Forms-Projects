using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.UI
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
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
