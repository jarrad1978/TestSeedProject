using TestSeedProject.Books;
using Xunit;

namespace TestSeedProject.EntityFrameworkCore.Applications.Books;

[Collection(TestSeedProjectTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<TestSeedProjectEntityFrameworkCoreTestModule>
{

}