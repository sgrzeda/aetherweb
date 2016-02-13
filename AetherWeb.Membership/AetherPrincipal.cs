using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
namespace AetherWeb.Membership
{
    class AetherPrincipal : System.Security.Principal.IPrincipal
    {
        public AetherPrincipal(AetherIdentity identity)
        {
            this.Identity = identity;
        }

        #region IPrincipal Members

        public IIdentity Identity { get; private set; }

        public bool IsInRole(string role)
        {
            return true;
        }
        #endregion
    }
}
