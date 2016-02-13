using System.Data.Entity.ModelConfiguration;

namespace AetherWeb.Database.Models.Configuration
{
    internal class AccountBaseConfiguration : EntityTypeConfiguration<AccountBase>
    {
        public AccountBaseConfiguration()
        {
            // PK
            HasKey(t => t.Account);

            // Properties
            Property(t => t.Account)
                .IsRequired()
                .HasMaxLength(32);

            Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(32);

            Property(t => t.IsUse)
                .IsRequired()
                .HasMaxLength(1)
                .IsFixedLength();

            // Mapping
            ToTable("ACCOUNT_TBL");
            Property(t => t.Account).HasColumnName("account");
            Property(t => t.Password).HasColumnName("password");
            Property(t => t.IsUse).HasColumnName("isuse");

            HasRequired(t => t.Details);
        }
    }
}