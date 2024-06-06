using ErpApp.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ErpApp.Application.IRepositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        IQueryable<T> GetAll(bool tracking);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking);
        Task<T> GetByIdAsync(string id, bool tracking);
    }
}
