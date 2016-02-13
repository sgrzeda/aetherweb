using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using AetherWeb.Database.Contexts;
using AetherWeb.Services.Authentication;
using AetherWeb.Services.Authentication.Web;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using AetherWeb.Database.Contexts.Interfaces;

namespace AetherWeb.Website
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            IUnityContainer container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            
            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();    
            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IAccountContext, AccountContext>(new InjectionConstructor());
            container.RegisterType<ICharacterContext, CharacterContext>(new InjectionConstructor());
            container.RegisterType<IUserManager, UserManager>();
            container.RegisterType<IIdentity, Services.Authentication.Principal.AetherIdentity>();
            container.RegisterType<IPrincipal, Services.Authentication.Principal.AetherPrincipal>();
        }
    }
}