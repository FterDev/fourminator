using fourminator.Lobby.Exceptions;
using fourminator.Lobby.Persistence;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace fourminator.Lobby.Hubs
{
    internal class LobbyHub : Hub
    {
        private ILogger<LobbyHub> _logger;
        private IList<User> _lobbyUsers;
        public LobbyHub(ILogger<LobbyHub> logger, IList<User> lobbyUsers)
        {
            _logger = logger;
            _lobbyUsers = lobbyUsers;
        }


        internal async Task SetNewUser(string nickname, ushort uniqueIdentifier)
        {
            try
            {
                var user = new User()
                {
                    Id = new Guid(nickname),
                    ClientId = this.Context.ConnectionId,
                    Nickname = nickname,
                    UniqueIdentifier = uniqueIdentifier
                };
                await user.ConnectUser(_lobbyUsers);
                await Clients.All.SendAsync("ReceiveLobbyList", _lobbyUsers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw new HubException(ex.Message);
            }
            
        }

        public override Task OnDisconnectedAsync(Exception? exception)
        {

            var newException = exception;
            try
            {
                RemoveUserFromLobby();
            }
            catch (Exception ex)
            {
                newException = ex;
            }
            return base.OnDisconnectedAsync(newException);
        }

        private Task RemoveUserFromLobby()
        {
            try
            {
                var user = _lobbyUsers.Where(u => u.ClientId == Context.ConnectionId).First();
                _lobbyUsers.Remove(user);
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                throw new InvalidClientIdException(ex);
            }
        }
    }
}
