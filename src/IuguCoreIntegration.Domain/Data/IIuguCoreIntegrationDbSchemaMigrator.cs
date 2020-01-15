using System.Threading.Tasks;

namespace IuguCoreIntegration.Data
{
    public interface IIuguCoreIntegrationDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
