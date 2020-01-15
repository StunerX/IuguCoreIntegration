using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace IuguCoreIntegration.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(IuguCoreIntegrationHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class IuguCoreIntegrationConsoleApiClientModule : AbpModule
    {
        
    }
}
