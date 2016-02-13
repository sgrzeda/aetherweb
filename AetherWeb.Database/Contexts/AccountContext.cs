using System.Data.Entity;
using System.Threading.Tasks;
using AetherWeb.Database.Contexts.Interfaces;
using AetherWeb.Database.Models;
using AetherWeb.Database.Models.Configuration;

namespace AetherWeb.Database.Contexts
{
    public class AccountContext : DbContext, IAccountContext
    {
        public AccountContext(string connection_string)
            : base(connection_string)
        {
            // disable migrations
            System.Data.Entity.Database.SetInitializer<AccountContext>(null);
        }

        public AccountContext()
            : this("AccountContext")
        {
        }

        public bool CreateAccount(string username, string password_hash, string email, string ip)
        {
            if (Accounts.Find(username) != null)
                return false;

            Database.ExecuteSqlCommand("INSERT INTO ACCOUNT_TBL(" +
                                       "account, password, isuse, member, realname" +
                                       ") VALUES({0}, {1}, {2}, {3}, {4});",
                                       username,
                                       password_hash,
                                       "T",
                                       "A",
                                       " ");

            Database.ExecuteSqlCommand("INSERT INTO ACCOUNT_TBL_DETAIL(" +
                                       "account, gamecode, tester, m_chLoginAuthority," +
                                       "regdate, BlockTime, EndTime, WebTime, isuse," +
                                       "secession, email, RegistrationIP, LastIP, ForumAccount" +
                                       ")" +
                                       "VALUES(" +
                                       "{0}, {1}, {2}, {3}, GETDATE()," +
                                       "CONVERT(CHAR(8), GETDATE() - 1, 112)," +
                                       "CONVERT(CHAR(8), DATEADD(year, 10, GETDATE()), 112)," +
                                       "CONVERT(CHAR(8), GETDATE() - 1, 112)," +
                                       "{4}, NULL, {5}, {6}, {7}, {8}" +
                                       ");",
                                       username,
                                       "A000",
                                       2,
                                       "F",
                                       "T",
                                       email,
                                       ip,
                                       ip,
                                       username);

            return true;
        }

        public async Task<bool> CreateAccountAsync(string username, string password_hash, string email, string ip)
        {
            if ((await Accounts.FindAsync(username)) != null)
                return false;

            Task<int> command1_ = Database.ExecuteSqlCommandAsync("INSERT INTO ACCOUNT_TBL(" +
                                                                  "account, password, isuse, member, realname" +
                                                                  ") VALUES({0}, {1}, {2}, {3}, {4});",
                                                                  username,
                                                                  password_hash,
                                                                  "T",
                                                                  "A",
                                                                  " ");

            Task<int> command2_ = Database.ExecuteSqlCommandAsync("INSERT INTO ACCOUNT_TBL_DETAIL(" +
                                                                  "account, gamecode, tester, m_chLoginAuthority," +
                                                                  "regdate, BlockTime, EndTime, WebTime, isuse," +
                                                                  "secession, email, RegistrationIP, LastIP, ForumAccount" +
                                                                  ")" +
                                                                  "VALUES(" +
                                                                  "{0}, {1}, {2}, {3}, GETDATE()," +
                                                                  "CONVERT(CHAR(8), GETDATE() - 1, 112)," +
                                                                  "CONVERT(CHAR(8), DATEADD(year, 10, GETDATE()), 112)," +
                                                                  "CONVERT(CHAR(8), GETDATE() - 1, 112)," +
                                                                  "{4}, NULL, {5}, {6}, {7}, {8}" +
                                                                  ");",
                                                                  username,
                                                                  "A000",
                                                                  2,
                                                                  "F",
                                                                  "T",
                                                                  email,
                                                                  ip,
                                                                  ip,
                                                                  username);

            await command1_;
            await command2_;
            return true;
        }

        public IDbSet<AccountBase> Accounts { get; set; }
        public IDbSet<AccountDetail> AccountDetailValues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountBaseConfiguration());
            modelBuilder.Configurations.Add(new AccountDetailConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}