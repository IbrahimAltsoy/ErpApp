using ErpApp.Application.IRepositories.Notification;
using ErpApp.Persistance.Context;
using n=ErpApp.Domain.Entities;

namespace ErpApp.Persistance.Repositories.Notification
{
    public class NotificationWriteRepository : WriteRepository<n.Notification>, INotificationWriteRepository
    {
        public NotificationWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
