using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace fourminator.Lobby.Hubs
{
    internal class LobbyHub : Hub
    {
        private ILogger<LobbyHub> _logger;
        public LobbyHub(ILogger<LobbyHub> logger)
        {
            _logger = logger;
        }
    }
}
