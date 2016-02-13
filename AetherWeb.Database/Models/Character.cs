using System;
using AetherWeb.Common;

namespace AetherWeb.Database.Models
{
    public class Character
    {
        public string PlayerId { get; set; }
        public string ServerIndex { get; set; }
        public string Account { get; set; }
        public string Name { get; set; }
        public int? Slot { get; set; }
        public int? WorldId { get; set; }
        public int? Index { get; set; }
        public Vector3 Position { get; set; }
        public int? HitPoints { get; set; }
        public int? ManaPoints { get; set; }
        public int? FatiguePoints { get; set; }
        public int? Sex { get; set; }
        public int? Gold { get; set; }
        public int? JobId { get; set; }

        public Job Job
        {
            get { return (Job) JobId; }
        }

        public int? Strength { get; set; }
        public int? Stamina { get; set; }
        public int? Dexterity { get; set; }
        public int? Intelligence { get; set; }
        public int? Level { get; set; }
        public int? MaximumLevel { get; set; }
        public int? RemainingGP { get; set; }
        public int? RemainingLP { get; set; }
        public string Authority { get; set; }
        public int? Mode { get; set; }
        public int? PartyId { get; set; }
        public int? MurdererId { get; set; }
        public int? m_nFame { get; set; }
        public int? MessengerState { get; set; }
        public int? TotalPlayTime { get; set; }
        public string IsBlock { get; set; }

        public bool IsBlocked
        {
            get { return IsBlock[0] != 'F'; }
        }

        public string EndTime { get; set; }

        /// <summary>
        ///     Time at which account will be unblocked
        /// </summary>
        public string BlockTime { get; set; }

        public DateTime? CreateTime { get; set; }
        public string m_tGuildMember { get; set; }
        public int? SkillPoints { get; set; }
        public int MultiServer { get; set; }
        public int? m_SkillPoint { get; set; } // ??
        public int? m_SkillLv { get; set; } // ??
        public long? m_SkillExp { get; set; } // ??
        public int PKValue { get; set; }
        public int PKPropensity { get; set; }
        public int PKExp { get; set; }
        public long? AngelExp { get; set; }
        public int AngelLevel { get; set; }
        public int? m_nHonor { get; set; }
        public int? LayerId { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Slaughter { get; set; }
        public int Perins { get; set; }
        public int VendorNpcId { get; set; }
    }
}