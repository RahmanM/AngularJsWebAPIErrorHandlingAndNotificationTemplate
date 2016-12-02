using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;
using Weather.Repositories;

namespace Weather
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
          
            // List of dependencies to be resoved by container!
            container.RegisterType<ICitiesRepository, CitiesRepository>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}