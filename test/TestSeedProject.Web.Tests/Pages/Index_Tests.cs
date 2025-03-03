using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TestSeedProject.Pages;

[Collection(TestSeedProjectTestConsts.CollectionDefinitionName)]
public class Index_Tests : TestSeedProjectWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
