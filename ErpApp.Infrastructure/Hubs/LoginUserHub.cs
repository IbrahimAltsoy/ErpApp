using ErpApp.Application.Services.HubService;
using ErpApp.Infrastructure.Hubs.FunctionName;
using ErpApp.Infrastructure.Services.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace ErpApp.Infrastructure.Hubs
{
    public class LoginUserHub:Hub
    {
        readonly ILoginUserHubService _loginUserHubService;
        public LoginUserHub(ILoginUserHubService loginUserHubService)
        {
            _loginUserHubService = loginUserHubService;
        }

        public async override Task OnConnectedAsync()
        {
            await _loginUserHubService.SendMessage("Servisten eklendi");
            await Clients.All.SendAsync(ReceiveFunctionNames.LoginUserMessage, "Eklendi dfdgfh");
            await base.OnConnectedAsync();
        }
    }
}
