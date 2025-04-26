using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourminator.Lobby.Persistence
{
    public class UserDto
    {
        public required string Nickname { get; set; }
        public ushort UniqueIdentifier { get; set; }
        public UserDto(User u)
        {
            Nickname = u.Nickname;
            UniqueIdentifier = u.UniqueIdentifier;
        }
    }

   
}
