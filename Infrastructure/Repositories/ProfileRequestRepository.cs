using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.SQL.Data;
using Microsoft.Extensions.Configuration;
using PK.BuildingBlocks.Repository;

namespace DS.Infrastructure.SQL.Repositories
{
    public class ProfileRequestRepository : RepositoryEF<Profile>, IProfileRequestRepos
    {
        private readonly DSDBContext _dbContext;
        public IConfiguration _configuration;

        public ProfileRequestRepository(DSDBContext dBContext, IConfiguration configuration) : base(dBContext)
        {
            _dbContext = dBContext;
            _configuration = configuration;

        }
    }
}
