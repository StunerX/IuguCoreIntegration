using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace IuguCoreIntegration.Data
{
    /* This is used if database provider does't define
     * IIuguCoreIntegrationDbSchemaMigrator implementation.
     */
    public class NullIuguCoreIntegrationDbSchemaMigrator : IIuguCoreIntegrationDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}