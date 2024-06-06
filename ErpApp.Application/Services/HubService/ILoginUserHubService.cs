namespace ErpApp.Application.Services.HubService
{
    public interface ILoginUserHubService
    {
        Task SendMessage(string message);
    }
}
