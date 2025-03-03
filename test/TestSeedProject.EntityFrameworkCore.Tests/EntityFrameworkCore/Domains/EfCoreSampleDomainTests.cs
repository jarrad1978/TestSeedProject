using TestSeedProject.Samples;
using Xunit;

namespace TestSeedProject.EntityFrameworkCore.Domains;

[Collection(TestSeedProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TestSeedProjectEntityFrameworkCoreTestModule>
{

}
