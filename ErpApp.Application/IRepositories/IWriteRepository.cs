using ErpApp.Domain.Entities.Common;

namespace ErpApp.Application.IRepositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entity);

        bool Update(T entity);

        bool Delete(T entity);
        Task<bool> DeleteAsync(string id);
        bool DeleteRange(List<T> entities);

        Task<int> SaveChanges();
    }
}
