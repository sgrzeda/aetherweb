using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AetherWeb.Database.Contexts.Interfaces;
using AetherWeb.Database.Models;
using AetherWeb.Services.Authentication.Web;
using System.Data.Entity;

namespace AetherWeb.Services.Authentication
{
    public class UserManager : IUserManager
    {
        private IAccountContext _account_context;
        private ICharacterContext _character_context;

        private Dictionary<string, IUser> _users; 

        public UserManager(IAccountContext account_context, ICharacterContext character_context)
        {
            _account_context = account_context;
            _character_context = character_context;
            _users = new Dictionary<string, IUser>();
        }

        public IUser this[string account]
        {
            get { return GetUser(account); }
        }

        public IUser GetUser(string account)
        {
            if (_users[account] != null)
                _users[account] = new User(account, this);
            return _users[account];
        }

        public bool ValidateCredentials(string account, string password)
        {
            AccountBase account_ = GetAccount(account);
            if (account_ == null)
                return false;
            if (account_.Password != GetPasswordHash(password))
                return false;
            return true;
        }

        public AccountBase GetAccount(string account)
        {
            return _account_context.Accounts.Find(account);
        }

        public async Task<AccountBase> GetAccountAsync(string account)
        {
            return await _account_context.Accounts.FindAsync(account);
        }

        public Character GetCharacter(string name)
        {
            return _character_context.Characters.Find(name);
        }

        public async Task<Character> GetCharacterAsync(string name)
        {
            return await _character_context.Characters.FindAsync(name);
        }

        public List<Character> GetCharactersByAccount(string account)
        {
            return _character_context.Characters.Where(t => t.Account == account).ToList();
        }

        public async Task<List<Character>> GetCharactersByAccountAsync(string account)
        {
            return await _character_context.Characters.Where(t => t.Account == account).ToListAsync();
        }

        public static string GetPasswordHash(string password)
        {
            return GetMD5Hash("napperispro" + password);
        }

        public static string GetMD5Hash(string value)
        {
            MD5 md5_hasher_ = MD5.Create();
            byte[] data = md5_hasher_.ComputeHash(Encoding.Default.GetBytes(value));
            var string_builder_ = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                string_builder_.Append(data[i].ToString("x2"));
            }
            return string_builder_.ToString();
        }
    }
}
