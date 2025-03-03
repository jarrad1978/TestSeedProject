using Xunit;

namespace TestSeedProject.EntityFrameworkCore;

[CollectionDefinition(TestSeedProjectTestConsts.CollectionDefinitionName)]
public class TestSeedProjectEntityFrameworkCoreCollection : ICollectionFixture<TestSeedProjectEntityFrameworkCoreFixture>
{

}
