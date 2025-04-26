using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourminator.Lobby.Persistence
{
    internal class User
    {
        public Guid Id { get; set; }
        public required string ClientId { get; set; }
        public required string Nickname { get; set; }
        public ushort UniqueIdentifier { get; set; }
    }
}
