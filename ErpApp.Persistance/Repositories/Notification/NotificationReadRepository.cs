using ErpApp.Application.IRepositories.Notification;
using ErpApp.Persistance.Context;
using n = ErpApp.Domain.Entities;

namespace ErpApp.Persistance.Repositories.Notification
{
    public class NotificationReadRepository : ReadRepository<n.Notification>, INotificationReadRepository
    {
        public NotificationReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
