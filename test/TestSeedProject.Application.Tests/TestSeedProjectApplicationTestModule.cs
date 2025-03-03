using Volo.Abp.Modularity;

namespace TestSeedProject;

[DependsOn(
    typeof(TestSeedProjectApplicationModule),
    typeof(TestSeedProjectDomainTestModule)
)]
public class TestSeedProjectApplicationTestModule : AbpModule
{

}
