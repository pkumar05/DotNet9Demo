using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.SQL.Data;
using Microsoft.Extensions.Configuration;
using PK.BuildingBlocks.Repository;

namespace Infrastructure.SQL.Repositories
{
    public class DepartmentsRequestRepository : RepositoryEF<Departments>, IDepartmentsRequestRepos
    {
        private readonly DSDBContext _dbContext;
        public IConfiguration _configuration;

        public DepartmentsRequestRepository(DSDBContext dBContext, IConfiguration configuration) : base(dBContext)
        {
            _dbContext = dBContext;
            _configuration = configuration;

        }
    }
}
