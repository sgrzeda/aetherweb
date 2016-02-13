namespace AetherWeb.Common.Authentication
{
    /*
     * From authorization.h
    #define AUTH_OBSERVER      'D'
    #define AUTH_GENERAL       'F'
    #define AUTH_LOGCHATTING   'G'
    #define AUTH_JOURNALIST    'H'
    #define AUTH_HELPER        'J'
    #define AUTH_GAMEMASTER    'L'
    #define AUTH_SUPERVISOR    'M'
    #define AUTH_MANAGER       'N'
    #define AUTH_OPERATOR      'O'
    #define AUTH_ADMINISTRATOR 'P'
     */

    public enum Authorization
    {
        Observer = 'D',
        General = 'F',
        LogChatting = 'G',
        Journalist = 'H',
        Helper = 'J',
        Gamemaster = 'L',
        Supervisor = 'M',
        Manager = 'N',
        Operator = 'O',
        Administrator = 'P'
    }
}