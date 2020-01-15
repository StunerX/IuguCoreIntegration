using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace IuguCoreIntegration.Data
{
    public class IuguCoreIntegrationDbMigrationService : ITransientDependency
    {
        public ILogger<IuguCoreIntegrationDbMigrationService> Logger { get; set; }

        private readonly IDataSeeder _dataSeeder;
        private readonly IIuguCoreIntegrationDbSchemaMigrator _dbSchemaMigrator;

        public IuguCoreIntegrationDbMigrationService(
            IDataSeeder dataSeeder,
            IIuguCoreIntegrationDbSchemaMigrator dbSchemaMigrator)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrator = dbSchemaMigrator;

            Logger = NullLogger<IuguCoreIntegrationDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            Logger.LogInformation("Migrating database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Executing database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed database migrations.");
        }
    }
}