using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using DogVDog.Web.Services;
using DogVDog.Web.Services.Interfaces;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Filters;

namespace DogVDog.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IBreedService, BreedService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            //code added from sabio.core
            //config.DependencyResolver = new UnityResolver(container);

            //List<System.Web.Http.Filters.IFilterProvider> providers = config.Services.GetFilterProviders().ToList();

            //config.Services.Add(typeof(System.Web.Http.Filters.IFilterProvider),
            //                                                new UnityActionFilterProvider(container));

            //System.Web.Http.Filters.IFilterProvider defaultprovider = providers.First(p => p is ActionDescriptorFilterProvider);

            //config.Services.Remove(typeof(System.Web.Http.Filters.IFilterProvider), defaultprovider);
        }
    }
}