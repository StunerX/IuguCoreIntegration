using IuguCoreIntegration.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace IuguCoreIntegration
{
    [DependsOn(
        typeof(IuguCoreIntegrationEntityFrameworkCoreTestModule)
        )]
    public class IuguCoreIntegrationDomainTestModule : AbpModule
    {

    }
}