using MediatR;
using MediatR.Pipeline;
using Ninject;
using Ninject.Modules;
using Ninject.Planning.Bindings.Resolvers;
using System;
using   Ninject.Extensions.Conventions; 



namespace Northwind.Root
{
    public sealed class IocContainer
    {
        private static readonly Lazy<IocContainer> lazy =  new Lazy<IocContainer>(() => new IocContainer());

         
        public IKernel  Kernel { get; private set; }




        private IocContainer()
        {
            Kernel = new StandardKernel();
 

        }

        public void InitMediatR()
        {
            Kernel.Components.Add<IBindingResolver, ContravariantBindingResolver>();
 
            //Pipeline
            Kernel.Bind(typeof(IPipelineBehavior<,>)).To(typeof(RequestPreProcessorBehavior<,>));
            Kernel.Bind(typeof(IPipelineBehavior<,>)).To(typeof(RequestPostProcessorBehavior<,>));
            Action<Ninject.Extensions.Conventions.Syntax.IFromSyntax> configure = scan => scan.FromAssemblyContaining<IMediator>().SelectAllClasses().BindDefaultInterface();
            Kernel.Bind(configure);

            Kernel.Bind(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
            Kernel.Bind(typeof(IPipelineBehavior<,>), typeof(RequestPostProcessorBehavior<,>));
            Kernel.Bind<ServiceFactory>().ToMethod(ctx => t => ctx.Kernel.TryGet(t));

            this.Mediator = Kernel.Get<IMediator>();
        }

        public   T Resolve<T>()
        {
            return  Kernel.Get<T>();
        }


        public static IocContainer Instance { get { return lazy.Value; } }

        private IMediator Mediator { get; set; }

        public   void LoadModule(INinjectModule module)
        {
            this. Kernel.Load(module);
        }

       
    }

}
