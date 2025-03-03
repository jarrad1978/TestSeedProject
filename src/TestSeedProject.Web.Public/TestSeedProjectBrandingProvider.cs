using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using TestSeedProject.Localization;

namespace TestSeedProject.Web.Public;

[Dependency(ReplaceServices = true)]
public class TestSeedProjectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TestSeedProjectResource> _localizer;

    public TestSeedProjectBrandingProvider(IStringLocalizer<TestSeedProjectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
