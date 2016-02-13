using System.Data.Entity.ModelConfiguration;

namespace AetherWeb.Database.Models.Configuration
{
    internal class AccountDetailConfiguration : EntityTypeConfiguration<AccountDetail>
    {
        public AccountDetailConfiguration()
        {
            // PK
            HasKey(t => t.Account);

            // Properties
            Property(t => t.Account)
                .IsRequired()
                .HasMaxLength(32);

            Property(t => t.LoginAuthority)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            Property(t => t.BlockTime)
                .IsFixedLength()
                .HasMaxLength(8);

            Property(t => t.EndTime)
                .IsFixedLength()
                .HasMaxLength(8);

            Property(t => t.IsUse)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            Property(t => t.Email)
                .HasMaxLength(100);

            Property(t => t.RegistrationIP)
                .HasMaxLength(32);

            Property(t => t.LastIP)
                .HasMaxLength(32);

            Property(t => t.AuthorizationUpdateReason)
                .HasMaxLength(100);

            Property(t => t.BanOperator)
                .HasMaxLength(50);

            Property(t => t.ForumAccount)
                .IsRequired()
                .HasMaxLength(50);

            // Mapping
            ToTable("ACCOUNT_TBL_DETAIL");
            Property(t => t.Account).HasColumnName("account");
            Property(t => t.LoginAuthority).HasColumnName("m_chLoginAuthority");
            Property(t => t.RegistrationDate).HasColumnName("regdate");
            Property(t => t.BlockTime).HasColumnName("BlockTime");
            Property(t => t.EndTime).HasColumnName("EndTime");
            Property(t => t.IsUse).HasColumnName("isuse");
            Property(t => t.Email).HasColumnName("email");
            Property(t => t.RegistrationIP).HasColumnName("RegistrationIP");
            Property(t => t.LastIP).HasColumnName("LastIP");
            Property(t => t.AuthorizationUpdateReason).HasColumnName("AuthUpdateReason");
            Property(t => t.MonthlyDonations).HasColumnName("MonthlyDonations");
            Property(t => t.DailyDonations).HasColumnName("DailyDonations");
            Property(t => t.MonthlyLastReset).HasColumnName("MonthlyLastReset");
            Property(t => t.DailyLastReset).HasColumnName("DailyLastReset");
            Property(t => t.dPoints).HasColumnName("dPoints");
            Property(t => t.BanOperator).HasColumnName("szBanOper");
            Property(t => t.ForumAccount).HasColumnName("ForumAccount");
            Property(t => t.ChargebackPoints).HasColumnName("ChargebackPoints");
            Property(t => t.LastAuthUpdate).HasColumnName("LastAuthUpdate");
        }
    }
}