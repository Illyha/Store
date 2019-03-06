using System;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;


namespace Store
{
    public class NinjectConfig
    {
        public static void RegisterDependencies()
        {
            //1 class configurator for instance-abstraction bindings
            NinjectModule nm = new CustomNinjectModule();

            //2 Ninject main functionallity creation
            StandardKernel kernel = new StandardKernel(nm);

            //3 resolver for all registered dependencies
            NinjectDependencyResolver ndr = new NinjectDependencyResolver(kernel);

            //4 register resolver 
            DependencyResolver.SetResolver(ndr);

        }
    }
}