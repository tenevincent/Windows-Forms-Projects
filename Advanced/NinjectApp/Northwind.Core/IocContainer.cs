using Ninject;
using Ninject.Modules;
using System;

namespace Northwind.Core
{
    public sealed class IocContainer
    {
        private static readonly Lazy<IocContainer> lazy =  new Lazy<IocContainer>(() => new IocContainer());



        public IKernel Kernel;
        private IocContainer()
        {
           Kernel = new StandardKernel();
        }

        public   T Resolve<T>()
        {
            return Kernel.Get<T>();
        }


        public static IocContainer Instance { get { return lazy.Value; } }

 

        public   void LoadModule(INinjectModule module)
        {
            this.Kernel.Load(module);
        }

       
    }

}
