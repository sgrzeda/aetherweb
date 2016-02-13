using System;
using System.Security.Principal;
using AetherWeb.Common.Authentication;

namespace AetherWeb.Services.Authentication.Principal
{
    public class AetherPrincipal : IPrincipal
    {
        public AetherPrincipal(AetherIdentity identity)
        {
            Identity = identity;
        }

        #region IPrincipal Members

        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
            return true;
        }

        public bool IsInRole(Authorization role)
        {
            throw new NotImplementedException();
            return true;
        }

        #endregion
    }
}