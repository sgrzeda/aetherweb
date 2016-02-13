using System.Security.Principal;
using AetherWeb.Services.Authentication.Web;

namespace AetherWeb.Services.Authentication.Principal
{
    public class AetherIdentity : IIdentity
    {
        private IUserManager _user_manager;
        public IUser CurrentUser
        {
            get { return _user_manager[Name]; }
        }
        public AetherIdentity(string name, IUserManager user_manager)
        {
            Name = name;
            _user_manager = user_manager;
        }

        #region IIdentity Members

        public string AuthenticationType
        {
            get { return "Custom"; }
        }

        public bool IsAuthenticated
        {
            get { return !string.IsNullOrEmpty(Name); }
        }

        public string Name { get; private set; }

        #endregion
    }
}