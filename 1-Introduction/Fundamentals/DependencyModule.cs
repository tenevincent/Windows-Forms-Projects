﻿using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.ButtonsApp
{
    public class DependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IApplicationShellView>().To<MainFormApp>();

 
        }
    }
}
