namespace AetherWeb.Common
{
    /* from defineJob.h
     * // Job
#define JOB_VAGRANT                 0 
#define MAX_JOBBASE                 1
  
// Expert
#define JOB_MERCENARY               1 // ±âº» Á÷¾÷µé
#define JOB_ACROBAT                 2
#define JOB_ASSIST                  3
#define JOB_MAGICIAN                4
#define JOB_PUPPETEER               5
#define MAX_EXPERT                  6

// Professional
#define JOB_KNIGHT      		6
#define JOB_BLADE			7
#define JOB_JESTER		        8
#define JOB_RANGER                   9
#define JOB_RINGMASTER               10
#define JOB_BILLPOSTER               11
#define JOB_PSYCHIKEEPER		12
#define JOB_ELEMENTOR			13
#define JOB_GATEKEEPER               14
#define JOB_DOPPLER                  15
#define MAX_PROFESSIONAL             16

// Master
#define JOB_KNIGHT_MASTER      		16
#define JOB_BLADE_MASTER			17
#define JOB_JESTER_MASTER		        18
#define JOB_RANGER_MASTER                   19
#define JOB_RINGMASTER_MASTER               20
#define JOB_BILLPOSTER_MASTER               21
#define JOB_PSYCHIKEEPER_MASTER		22
#define JOB_ELEMENTOR_MASTER		23
#define MAX_MASTER	             24

// Hero
#define JOB_KNIGHT_HERO      		24
#define JOB_BLADE_HERO			25
#define JOB_JESTER_HERO		        26
#define JOB_RANGER_HERO                   27
#define JOB_RINGMASTER_HERO               28
#define JOB_BILLPOSTER_HERO               29
#define JOB_PSYCHIKEEPER_HERO		30
#define JOB_ELEMENTOR_HERO		31
#define MAX_HERO	             32

#if __VER >= 16

// 3Â÷ Á÷¾÷
#define	JOB_LORDTEMPLER_HERO	32
#define JOB_STORMBLADE_HERO		33
#define JOB_WINDLURKER_HERO		34
#define JOB_CRACKSHOOTER_HERO	35
#define JOB_FLORIST_HERO		36
#define JOB_FORCEMASTER_HERO	37
#define JOB_MENTALIST_HERO		38
#define JOB_ELEMENTORLORD_HERO	39

#define MAX_LEGEND_HERO	             40

#endif // __3RD_LEGEND16
     */

    public enum Job
    {
        Vargant = 0,
        // expert
        Mercenary = 1,
        Acrobat = 2,
        Assist = 3,
        Magician = 4,
        Puppeteer = 5,
        // Professional
        Knight = 6,
        Blade = 7,
        Jester = 8,
        Ranger = 9,
        Ringmaster = 10,
        Billposter = 11,
        Psychikeeper = 12,
        Elementor = 13,
        Gatekeeper = 14,
        Doppler = 15,
        // Master
        Knight_Master = 16,
        Blade_Master = 17,
        Jester_Master = 18,
        Ranger_Master = 19,
        Ringmaster_Master = 20,
        Billposter_Master = 21,
        Psychikeeper_Master = 22,
        Elementor_Master = 23,
        // Hero
        Knight_Hero = 24,
        Blade_Hero = 25,
        Jester_Hero = 26,
        Ranger_Hero = 27,
        Ringmaster_Hero = 28,
        Billposter_Hero = 29,
        Psychikeeper_Hero = 30,
        Elementor_Hero = 31,
        // New jobs
        Templar = 32,
        Slayer = 33,
        Harlequin = 34,
        Crackshooter = 35,
        Seraph = 36,
        Force_Master = 37,
        Mentalist = 38,
        Arcanist = 39
    }
}