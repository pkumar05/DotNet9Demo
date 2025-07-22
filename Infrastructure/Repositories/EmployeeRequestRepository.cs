using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.SQL.Data;
using Microsoft.Extensions.Configuration;
using PK.BuildingBlocks.Repository;

namespace DS.Infrastructure.SQL.Repositories
{
    public class EmployeeRequestRepository : RepositoryEF<Employees>, IEmployeeRequestRepos
    {
        private readonly DSDBContext _dbContext;
        public IConfiguration _configuration;

        public EmployeeRequestRepository(DSDBContext dBContext, IConfiguration configuration) : base(dBContext)
        {
            _dbContext = dBContext;
            _configuration = configuration;

        }
    }
}
