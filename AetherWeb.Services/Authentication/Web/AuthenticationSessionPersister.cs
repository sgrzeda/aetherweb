using System;
using System.Web;

namespace AetherWeb.Services.Authentication.Web
{
    public static class AuthenticationSessionPersister
    {
        public static string Username
        {
            get
            {
                if (HttpContext.Current == null)
                {
#if DEBUG
                    throw new Exception("HttpContext does not exist in the current context.");
#endif
                    return null;
                }
                if (HttpContext.Current.Session["account"] != null)
                    return (string) HttpContext.Current.Session["account"];
                return null;
            }
            set
            {
#if DEBUG
                if (HttpContext.Current == null)
                    throw new Exception("HttpContext does not exist in the current context.");
#endif
                HttpContext.Current.Session["account"] = value;
            }
        }
    }
}