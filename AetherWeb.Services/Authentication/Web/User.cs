using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AetherWeb.Database.Contexts.Interfaces;
using AetherWeb.Database.Models;
using System.Linq;

namespace AetherWeb.Services.Authentication.Web
{
    public class User : IUser
    {
        private IUserManager _user_manager;

        public string Name { get; private set; }

        private AccountBase _account;
        private List<Character> _characters;

        public AccountBase Account
        {
            get { return _account ?? (_account = _user_manager.GetAccount(Name)); }
        }

        public List<Character> Characters
        {
            get { return _user_manager.GetCharactersByAccount(Name); }
        }

        public User(string username, IUserManager user_manager)
        {
            _user_manager = user_manager;
            Name = username;
        }
    }
}