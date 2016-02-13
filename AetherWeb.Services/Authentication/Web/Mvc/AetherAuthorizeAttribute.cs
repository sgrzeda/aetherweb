using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using AetherWeb.Common.Authentication;

namespace AetherWeb.Services.Authentication.Web.Mvc
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AetherAuthorize : AuthorizeAttribute
    {
        private readonly Authorization _role;

        public AetherAuthorize(Authorization role)
        {
            _role = role;
        }

        ~AetherAuthorize()
        {
            Debug.WriteLine("Auth Attribute Destroyed");
        }

        protected override bool AuthorizeCore(HttpContextBase http_context)
        {
            if (http_context == null)
                throw new ArgumentNullException("http_context");

            if (!http_context.User.Identity.IsAuthenticated)
                return false;

            //if (User.CurrentUser.Account.Details.LoginAuthorityEnum < _role)
              //  return false;

            return true;
        }
    }
}