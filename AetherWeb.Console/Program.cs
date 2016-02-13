using System.Linq;
using AetherWeb.Database.Contexts;
using AetherWeb.Database.Models;

namespace AetherWeb.Console
{
    internal class Program
    {
        private static void Main(string[] args)

        {
            var test = new AccountContext();
            AccountBase magic = test.Accounts.Where(t => t.Account == "forest").First();
            if (magic != null)
                System.Console.WriteLine(magic.Password);
            else
            {
                System.Console.WriteLine("NULL");
            }
            magic = test.Accounts.Find("asdasda");
            if (magic != null)
                System.Console.WriteLine(magic.Details.Email);
            else
            {
                System.Console.WriteLine("NULL");
            }
            System.Console.Read();
        }
    }
}