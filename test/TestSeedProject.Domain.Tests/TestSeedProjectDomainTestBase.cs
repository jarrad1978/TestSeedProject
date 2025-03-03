using Volo.Abp.Modularity;

namespace TestSeedProject;

/* Inherit from this class for your domain layer tests. */
public abstract class TestSeedProjectDomainTestBase<TStartupModule> : TestSeedProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
