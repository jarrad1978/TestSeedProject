using TestSeedProject.Samples;
using Xunit;

namespace TestSeedProject.EntityFrameworkCore.Applications;

[Collection(TestSeedProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TestSeedProjectEntityFrameworkCoreTestModule>
{

}
