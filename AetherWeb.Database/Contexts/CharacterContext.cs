using System.Data.Entity;
using AetherWeb.Database.Models;
using AetherWeb.Database.Models.Configuration;
using AetherWeb.Database.Contexts.Interfaces;

namespace AetherWeb.Database.Contexts
{
    public class CharacterContext : DbContext, ICharacterContext
    {
        public IDbSet<Character> Characters { get; set; }

        public CharacterContext()
            : this("CharacterContext")
        {
        }

        public CharacterContext(string connection_string)
            : base(connection_string)
        {
            System.Data.Entity.Database.SetInitializer<CharacterContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder model_builder)
        {
            model_builder.Configurations.Add(new CharacterConfiguration());
        }
    }
}