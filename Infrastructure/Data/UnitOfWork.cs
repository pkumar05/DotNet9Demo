using PK.BuildingBlocks.Infrastructure;

namespace Infrastructure.SQL.Data
{
    public class UnitOfWork : IUnitOfWork
    {

        private DSDBContext _dbContext;

        public UnitOfWork(DSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AffectedRows { get; private set; }

        public int Commit()
        {
            AffectedRows = _dbContext.SaveChanges();
            return AffectedRows;
        }

        public async Task<int> CommitAsync()
        {
            AffectedRows = await _dbContext.SaveChangesAsync();
            return AffectedRows;
        }

    }
}
