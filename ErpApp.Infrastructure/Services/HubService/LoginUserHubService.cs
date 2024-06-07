using ErpApp.Application.IRepositories.Notification;
using ErpApp.Application.Services.HubService;
using ErpApp.Domain.Entities;
using ErpApp.Infrastructure.Hubs;
using ErpApp.Infrastructure.Hubs.FunctionName;
using Microsoft.AspNetCore.SignalR;

namespace ErpApp.Infrastructure.Services.HubService
{
    public class LoginUserHubService : ILoginUserHubService
    {
        readonly IHubContext<LoginUserHub> _hubContext;
        readonly INotificationWriteRepository _notificationRepository;

        public LoginUserHubService(IHubContext<LoginUserHub> hubContext, INotificationWriteRepository notificationRepository)
        {
            _hubContext = hubContext;
            _notificationRepository = notificationRepository;
        }

        public async Task SendMessage(string message)
        {           
            Notification notification = new Notification
            {
                Message = message,
            };
            await _notificationRepository.AddAsync(notification);
            await _notificationRepository.SaveChanges();
        }
    }
}
