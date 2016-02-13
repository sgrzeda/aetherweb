using System.Collections.Generic;
using System.Threading.Tasks;
using AetherWeb.Database.Models;
using AetherWeb.Services.Authentication.Web;

namespace AetherWeb.Services.Authentication
{
    public interface IUserManager
    {
        IUser this[string account] { get; }
        IUser GetUser(string account);
        bool ValidateCredentials(string account, string password);

        AccountBase GetAccount(string account);
        Task<AccountBase> GetAccountAsync(string account);

        Character GetCharacter(string name);
        Task<Character> GetCharacterAsync(string name);
        List<Character> GetCharactersByAccount(string account);
        Task<List<Character>>  GetCharactersByAccountAsync(string account);
    }
}