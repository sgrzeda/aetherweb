using System;
using AetherWeb.Common.Authentication;

namespace AetherWeb.Database.Models
{
    public class AccountDetail
    {
        public string Account { get; set; }
        public string LoginAuthority { get; set; }

        public Authorization LoginAuthorityEnum
        {
            get
            {
                if (LoginAuthority[0] < 'P')
                    return (Authorization) LoginAuthority[0];

                return Authorization.Administrator;
            }
        }

        public DateTime RegistrationDate { get; set; }
        public string BlockTime { get; set; }
        public string EndTime { get; set; }
        public string IsUse { get; set; }
        public string Email { get; set; }
        public string RegistrationIP { get; set; }
        public string LastIP { get; set; }
        public string AuthorizationUpdateReason { get; set; }
        public int MonthlyDonations { get; set; }
        public int DailyDonations { get; set; }
        public DateTime MonthlyLastReset { get; set; }
        public DateTime DailyLastReset { get; set; }
        public int? dPoints { get; set; }
        public string BanOperator { get; set; }

        /// <summary>
        ///     From IPB, do not use
        /// </summary>
        public string ForumAccount { get; set; }

        public int ChargebackPoints { get; set; }
        public DateTime LastAuthUpdate { get; set; }

        public virtual AccountBase Base { get; set; }
    }
}