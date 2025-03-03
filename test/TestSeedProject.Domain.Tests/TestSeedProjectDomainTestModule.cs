using Volo.Abp.Modularity;

namespace TestSeedProject;

[DependsOn(
    typeof(TestSeedProjectDomainModule),
    typeof(TestSeedProjectTestBaseModule)
)]
public class TestSeedProjectDomainTestModule : AbpModule
{

}
