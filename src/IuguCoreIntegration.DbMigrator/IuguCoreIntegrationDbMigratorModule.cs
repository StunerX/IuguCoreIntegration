using IuguCoreIntegration.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace IuguCoreIntegration.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(IuguCoreIntegrationEntityFrameworkCoreDbMigrationsModule),
        typeof(IuguCoreIntegrationApplicationContractsModule)
        )]
    public class IuguCoreIntegrationDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
