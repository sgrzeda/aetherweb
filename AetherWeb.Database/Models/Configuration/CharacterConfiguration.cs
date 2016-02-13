using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AetherWeb.Database.Models.Configuration
{
    internal class CharacterConfiguration : EntityTypeConfiguration<Character>
    {
        public CharacterConfiguration()
        {
            // Primary Key
            HasKey(t => t.PlayerId);

            // Properties
            Property(t => t.PlayerId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(7);

            Property(t => t.ServerIndex)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            Property(t => t.Account)
                .HasMaxLength(32);

            Property(t => t.Name)
                .HasMaxLength(32);

            Property(t => t.Authority)
                .IsFixedLength()
                .HasMaxLength(1);

            Property(t => t.IsBlock)
                .IsFixedLength()
                .HasMaxLength(1);

            Property(t => t.EndTime)
                .IsFixedLength()
                .HasMaxLength(12);

            Property(t => t.BlockTime)
                .IsFixedLength()
                .HasMaxLength(8);

            Property(t => t.m_tGuildMember)
                .IsFixedLength()
                .HasMaxLength(14);

            Property(t => t.MultiServer)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.PKValue)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.PKPropensity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.PKExp)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.AngelLevel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Kills)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Deaths)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Slaughter)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Perins)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.VendorNpcId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("CHARACTER_TBL");
            Property(t => t.PlayerId).HasColumnName("m_idPlayer");
            Property(t => t.ServerIndex).HasColumnName("serverindex");
            Property(t => t.Account).HasColumnName("account");
            Property(t => t.Name).HasColumnName("m_szName");
            Property(t => t.Slot).HasColumnName("playerslot");
            Property(t => t.WorldId).HasColumnName("dwWorldID");
            Property(t => t.Index).HasColumnName("m_dwIndex");
            Property(t => t.Position.x).HasColumnName("m_vPos_x");
            Property(t => t.Position.y).HasColumnName("m_vPos_y");
            Property(t => t.Position.z).HasColumnName("m_vPos_z");
            Property(t => t.HitPoints).HasColumnName("m_nHitPoint");
            Property(t => t.ManaPoints).HasColumnName("m_nManaPoint");
            Property(t => t.FatiguePoints).HasColumnName("m_nFatiguePoint");
            Property(t => t.Sex).HasColumnName("m_dwSex");
            Property(t => t.Gold).HasColumnName("m_dwGold");
            Property(t => t.JobId).HasColumnName("m_nJob");
            Property(t => t.Strength).HasColumnName("m_nStr");
            Property(t => t.Stamina).HasColumnName("m_nSta");
            Property(t => t.Dexterity).HasColumnName("m_nDex");
            Property(t => t.Intelligence).HasColumnName("m_nInt");
            Property(t => t.Level).HasColumnName("m_nLevel");
            Property(t => t.MaximumLevel).HasColumnName("m_nMaximumLevel");
            Property(t => t.RemainingGP).HasColumnName("m_nRemainGP");
            Property(t => t.RemainingLP).HasColumnName("m_nRemainLP");
            Property(t => t.Authority).HasColumnName("m_chAuthority");
            Property(t => t.Mode).HasColumnName("m_dwMode");
            Property(t => t.PartyId).HasColumnName("m_idparty");
            Property(t => t.MurdererId).HasColumnName("m_idMuerderer");
            Property(t => t.m_nFame).HasColumnName("m_nFame");
            Property(t => t.MessengerState).HasColumnName("m_nMessengerState");
            Property(t => t.TotalPlayTime).HasColumnName("TotalPlayTime");
            Property(t => t.IsBlock).HasColumnName("isblock");
            Property(t => t.EndTime).HasColumnName("End_Time");
            Property(t => t.BlockTime).HasColumnName("BlockTime");
            Property(t => t.CreateTime).HasColumnName("CreateTime");
            ;
            Property(t => t.m_tGuildMember).HasColumnName("m_tGuildMember");
            Property(t => t.SkillPoints).HasColumnName("m_dwSkillPoint");
            Property(t => t.MultiServer).HasColumnName("MultiServer");
            Property(t => t.m_SkillPoint).HasColumnName("m_SkillPoint");
            Property(t => t.m_SkillLv).HasColumnName("m_SkillLv");
            Property(t => t.m_SkillExp).HasColumnName("m_SkillExp");
            Property(t => t.PKValue).HasColumnName("PKValue");
            Property(t => t.PKPropensity).HasColumnName("PKPropensity");
            Property(t => t.PKExp).HasColumnName("PKExp");
            Property(t => t.AngelExp).HasColumnName("AngelExp");
            Property(t => t.AngelLevel).HasColumnName("AngelLevel");
            Property(t => t.m_nHonor).HasColumnName("m_nHonor");
            Property(t => t.LayerId).HasColumnName("m_nLayer");
            Property(t => t.Kills).HasColumnName("m_nNumKill");
            Property(t => t.Deaths).HasColumnName("m_nNumDeath");
            Property(t => t.Slaughter).HasColumnName("m_nSlaughter");
            Property(t => t.Perins).HasColumnName("m_dwPerin");
            Property(t => t.VendorNpcId).HasColumnName("m_idVendorNPC");
        }
    }
}