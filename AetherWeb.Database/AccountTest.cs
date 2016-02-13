using System.Data.Entity;
using AetherWeb.Database.Models;
using AetherWeb.Database.Models.Configuration;

namespace AetherWeb.Database
{
    public class AccountTest : DbContext
    {
        public AccountTest()
            : base("ACCOUNT_01_DBFContext")
        {
        }

        public DbSet<AccountBase> Accounts { get; set; }
        public DbSet<AccountDetail> AccountDetailValues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountBaseConfiguration());
            modelBuilder.Configurations.Add(new AccountDetailConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}