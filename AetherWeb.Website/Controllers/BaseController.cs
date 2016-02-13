using System.Web.Mvc;
using AetherWeb.Services.Authentication;
using AetherWeb.Services.Authentication.Principal;
using AetherWeb.Services.Authentication.Web;
using Microsoft.Practices.Unity;
using System.Security.Principal;

namespace AetherWeb.Website.Controllers
{
    public class AsyncBaseController : AsyncController
    {
        [Dependency] 
        public IUserManager UserManager { get; set; }

        protected override void OnAuthorization(AuthorizationContext filter_context)
        {
            if (!string.IsNullOrEmpty(AuthenticationSessionPersister.Username))
            {
                filter_context.HttpContext.User = new AetherPrincipal(new AetherIdentity(AuthenticationSessionPersister.Username, UserManager));
                //new AetherPrincipal(new AetherIdentity(AuthenticationSessionPersister.Username));
            }
            base.OnAuthorization(filter_context);
        }
    }
}