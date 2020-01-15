using Volo.Abp.Modularity;

namespace IuguCoreIntegration
{
    [DependsOn(
        typeof(IuguCoreIntegrationApplicationModule),
        typeof(IuguCoreIntegrationDomainTestModule)
        )]
    public class IuguCoreIntegrationApplicationTestModule : AbpModule
    {

    }
}