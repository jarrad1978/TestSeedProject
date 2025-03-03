using System.Threading.Tasks;

namespace TestSeedProject.Data;

public interface ITestSeedProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
