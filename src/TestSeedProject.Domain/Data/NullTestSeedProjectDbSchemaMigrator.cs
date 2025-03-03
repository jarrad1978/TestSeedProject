using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestSeedProject.Data;

/* This is used if database provider does't define
 * ITestSeedProjectDbSchemaMigrator implementation.
 */
public class NullTestSeedProjectDbSchemaMigrator : ITestSeedProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
