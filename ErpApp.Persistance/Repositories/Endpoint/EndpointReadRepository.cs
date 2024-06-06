using ErpApp.Application.IRepositories.Endpoint;
using ErpApp.Persistance.Context;
using e=ErpApp.Domain.Entities;
namespace ErpApp.Persistance.Repositories.Endpoint
{
    public class EndpointReadRepository : ReadRepository<e.Endpoint>, IEndpointReadRepository
    {
        public EndpointReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
