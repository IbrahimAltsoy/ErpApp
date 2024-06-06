using ErpApp.Application.IRepositories.Endpoint;
using ErpApp.Persistance.Context;
using e = ErpApp.Domain.Entities;

namespace ErpApp.Persistance.Repositories.Endpoint
{
    public class EndpointWriteRepository : WriteRepository<e.Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
