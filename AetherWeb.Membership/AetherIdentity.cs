using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetherWeb.Membership
{
    class AetherIdentity : System.Security.Principal.IIdentity
    {
        public AetherIdentity(string name)
        {
            this.Name = name;
        }

        #region IIdentity Members

        public string AuthenticationType
        {
            get { return "Custom"; }
        }

        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(this.Name); }
        }

        public string Name { get; private set; }
        #endregion
    }
}
