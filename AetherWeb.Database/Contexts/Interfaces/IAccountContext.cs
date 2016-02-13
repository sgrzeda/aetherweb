using System.Data.Entity;
using System.Threading.Tasks;
using AetherWeb.Database.Models;

namespace AetherWeb.Database.Contexts.Interfaces
{
    public interface IAccountContext
    {
        IDbSet<AccountBase> Accounts { get; }
        IDbSet<AccountDetail> AccountDetailValues { get; }
        bool CreateAccount(string username, string password, string email, string ip);
        Task<bool> CreateAccountAsync(string username, string password, string email, string ip);
    }
}