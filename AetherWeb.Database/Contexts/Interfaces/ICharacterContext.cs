using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AetherWeb.Database.Models;

namespace AetherWeb.Database.Contexts.Interfaces
{
    public interface ICharacterContext
    {
        IDbSet<Character> Characters { get; }

    }
}
