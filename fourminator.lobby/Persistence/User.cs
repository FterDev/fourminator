using fourminator.Lobby.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourminator.Lobby.Persistence
{
    public class User
    {
        public Guid Id { get; set; }
        public required string ClientId { get; set; }
        public required string Nickname { get; set; }
        public ushort UniqueIdentifier { get; set; }

        internal Task ConnectUser(IList<User> connectedUsers)
        {
            connectedUsers.Add(this);
            return Task.CompletedTask;
        }

        internal Task DisconnectUser(IList<User> connectedUsers, string clientId)
        {
            try
            {
                var user = connectedUsers.Where(cu => cu.ClientId == clientId).First();
                connectedUsers.Remove(user);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                throw new InvalidClientIdException(ex);
            }
            
        }
    }
}
