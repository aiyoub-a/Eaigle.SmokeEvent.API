namespace Eaigle.SmokeEvent.API.SignalR.Hubs.Interfaces;

public interface IHubClient
{
    Task SmokeIncident(string message);
}