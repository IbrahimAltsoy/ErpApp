using Microsoft.AspNetCore.SignalR;

namespace ErpApp.Application.Services.HubService
{
    //CurrentUser bilgisi ile beraber kayıt altına alabiliriz.
    public interface ICreateUserHubService
    {
        Task SendMessage(string message);
    }
}
