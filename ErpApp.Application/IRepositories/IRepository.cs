using ErpApp.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ErpApp.Application.IRepositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        DbSet<T> Table { get; }

    }
}
