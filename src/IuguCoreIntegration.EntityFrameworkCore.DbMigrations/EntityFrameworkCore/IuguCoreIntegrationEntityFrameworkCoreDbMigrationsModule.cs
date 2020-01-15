using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace IuguCoreIntegration.EntityFrameworkCore
{
    [DependsOn(
        typeof(IuguCoreIntegrationEntityFrameworkCoreModule)
        )]
    public class IuguCoreIntegrationEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<IuguCoreIntegrationMigrationsDbContext>();
        }
    }
}
