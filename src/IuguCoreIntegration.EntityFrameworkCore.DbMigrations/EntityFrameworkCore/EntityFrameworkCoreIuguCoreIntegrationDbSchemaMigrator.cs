using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IuguCoreIntegration.Data;
using Volo.Abp.DependencyInjection;

namespace IuguCoreIntegration.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreIuguCoreIntegrationDbSchemaMigrator 
        : IIuguCoreIntegrationDbSchemaMigrator, ITransientDependency
    {
        private readonly IuguCoreIntegrationMigrationsDbContext _dbContext;

        public EntityFrameworkCoreIuguCoreIntegrationDbSchemaMigrator(IuguCoreIntegrationMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}