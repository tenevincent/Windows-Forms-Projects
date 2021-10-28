using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ButtonsApp
{
    public class CompositionRoot
    {
        private static IKernel ninjectKernel;

        public static void Initialize(INinjectModule module)
        {
            ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return ninjectKernel.Get<T>();
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            return ninjectKernel.GetAll<T>();
        }
    }
}
