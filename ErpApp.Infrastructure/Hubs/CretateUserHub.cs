using ErpApp.Application.Services.HubService;
using ErpApp.Infrastructure.Hubs.FunctionName;
using ErpApp.Infrastructure.Services.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace ErpApp.Infrastructure.Hubs
{
    public class CretateUserHub: Hub
    {
        readonly ICreateUserHubService _createUserHubService;

        public CretateUserHub(ICreateUserHubService createUserHubService)
        {
            _createUserHubService = createUserHubService;
        }

        public async override Task OnConnectedAsync()
        {
            await _createUserHubService.SendMessage("Servisten eklendi");
            await Clients.All.SendAsync(ReceiveFunctionNames.CreateUserMessage, "Eklendi dfdgfh");
             await base.OnConnectedAsync();
        }
    }
}
