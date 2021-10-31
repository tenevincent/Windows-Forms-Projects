using AutoMapper;
using MediatR;
using MediatR.Pipeline;
using Ninject;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Conventions.Syntax;
using Ninject.Modules;
using Ninject.Planning.Bindings.Resolvers;
using System;



namespace Core
{
    public sealed class IocContainer
    {
        private static readonly Lazy<IocContainer> lazy = new Lazy<IocContainer>(() => new IocContainer());
        // private IMediator Mediator { get; set; }

        public IKernel Kernel { get; private set; }




        private IocContainer()
        {
            Kernel = new StandardKernel();

            //Init();
            //InitMapper();
        }

        public void Init()
        {

            Kernel.Components.Add<IBindingResolver, ContravariantBindingResolver>();
            //Pipeline
            Kernel.Bind(typeof(IPipelineBehavior<,>)).To(typeof(RequestPreProcessorBehavior<,>));
            Kernel.Bind(typeof(IPipelineBehavior<,>)).To(typeof(RequestPostProcessorBehavior<,>));
            Action<IFromSyntax> configure = scan => scan.FromAssemblyContaining<IMediator>().SelectAllClasses().BindDefaultInterface();
            Kernel.Bind(configure);

            Kernel.Bind(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
            Kernel.Bind(typeof(IPipelineBehavior<,>), typeof(RequestPostProcessorBehavior<,>));
            Kernel.Bind<ServiceFactory>().ToMethod(ctx => t => ctx.Kernel.TryGet(t));

            //var config = new MapperConfiguration(cfg => { });
            //Kernel.Bind<IMapper>().ToConstant<IMapper>(config.CreateMapper());
            //InitMapper();
            ////  this.Mediator = Kernel.Get<IMediator>();
            //var config = new MapperConfiguration(cfg => {  });
            //IMapper iMapper = config.CreateMapper();
        }

        public void InitMapper( )
        {
            var mapperConfiguration = CreateConfiguration();

            Kernel.Bind<MapperConfiguration>().ToConstant(mapperConfiguration).InSingletonScope();

            // This teaches Ninject how to create automapper instances say if for instance
            // MyResolver has a constructor with a parameter that needs to be injected
            Kernel.Bind<IMapper>().ToMethod(ctx => new Mapper(mapperConfiguration, type => ctx.Kernel.Get(type)));
        }

        private MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(DoMapperConfig);
            return config;
        }

        private void DoMapperConfig(IMapperConfigurationExpression cfg)
        {
            cfg.AddMaps(GetType().Assembly);
            cfg.AddMaps(GetType().Assembly);

        }
        //private Action<IMapperConfigurationExpression> AddConfiguration()
        //{
        //    return cfg =>
        //    {
        //        // Add all profiles in current assembly
        //        cfg.AddMaps(GetType().Assembly);
        //    };
        //}

        public T Resolve<T>()
        {
            return Kernel.Get<T>();
        }


        public static IocContainer Instance { get { return lazy.Value; } }



        public void LoadModule(INinjectModule module)
        {
            this.Kernel.Load(module);
        }


    }

}
