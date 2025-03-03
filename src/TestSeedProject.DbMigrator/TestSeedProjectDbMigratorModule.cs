using TestSeedProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TestSeedProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestSeedProjectEntityFrameworkCoreModule),
    typeof(TestSeedProjectApplicationContractsModule)
)]
public class TestSeedProjectDbMigratorModule : AbpModule
{
}
