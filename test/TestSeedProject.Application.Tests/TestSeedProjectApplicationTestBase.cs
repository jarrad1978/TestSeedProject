using Volo.Abp.Modularity;

namespace TestSeedProject;

public abstract class TestSeedProjectApplicationTestBase<TStartupModule> : TestSeedProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
