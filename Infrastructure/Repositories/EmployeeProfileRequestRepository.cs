using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.SQL.Data;
using Microsoft.Extensions.Configuration;
using PK.BuildingBlocks.Repository;

namespace DS.Infrastructure.SQL.Repositories
{
    public class EmployeeProfileRequestRepository : RepositoryEF<EmployeeProfile>, IEmployeeProfileRequestRepos
    {
        private readonly DSDBContext _dbContext;
        public IConfiguration _configuration;

        public EmployeeProfileRequestRepository(DSDBContext dBContext, IConfiguration configuration) : base(dBContext)
        {
            _dbContext = dBContext;
            _configuration = configuration;

        }
    }
}
