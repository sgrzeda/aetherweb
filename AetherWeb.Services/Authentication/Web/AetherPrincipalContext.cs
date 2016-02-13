using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AetherWeb.Services.Authentication.Principal;

namespace AetherWeb.Services.Authentication.Web
{
    public static class AetherPrincipalContext
    {
        public static AetherPrincipal Principal { get { return (AetherPrincipal) HttpContext.Current.User; } }
        public static AetherIdentity Identity { get { return (AetherIdentity) HttpContext.Current.User.Identity; } }
    }
}
