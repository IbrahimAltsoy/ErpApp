using ErpApp.Application.IRepositories.Notification;
using ErpApp.Application.Services.HubService;
using ErpApp.Domain.Entities;
using ErpApp.Infrastructure.Hubs;
using ErpApp.Infrastructure.Hubs.FunctionName;
using Microsoft.AspNetCore.SignalR;

namespace ErpApp.Infrastructure.Services.Hubs
{
    public class CreateUserHubService : ICreateUserHubService
    {
        readonly IHubContext<CretateUserHub> _hubContext;
        readonly INotificationWriteRepository _notificationRepository;

        public CreateUserHubService(IHubContext<CretateUserHub> hubContext, INotificationWriteRepository notificationRepository)
        {
            _hubContext = hubContext;
            _notificationRepository = notificationRepository;
        }

        public async Task SendMessage(string message)
        {
            await _hubContext.Clients.All.SendAsync(ReceiveFunctionNames.CreateUserMessage, message);
            Notification notification = new Notification
            {
                Message = message,
            };
            await _notificationRepository.AddAsync(notification);
            await _notificationRepository.SaveChanges();
            int a = 5;

        }
    }
}
