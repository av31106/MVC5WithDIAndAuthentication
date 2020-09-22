using MVC5WithDIAndAuthontication.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVC5WithDIAndAuthontication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterSingleton<IEmployeeRepository, MockEmployeeRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}