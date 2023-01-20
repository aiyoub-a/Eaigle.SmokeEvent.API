using Eaigle.SmokeEvent.API.SignalR.Hubs.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace Eaigle.SmokeEvent.API.SignalR.Hubs;

public class HubClient : Hub<IHubClient>
{
    public async Task SmokeIncident(string message)
    {
        await Clients.All.SmokeIncident(message);
    }
}