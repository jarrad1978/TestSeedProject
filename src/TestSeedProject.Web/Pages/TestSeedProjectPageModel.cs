using TestSeedProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TestSeedProject.Web.Pages;

public abstract class TestSeedProjectPageModel : AbpPageModel
{
    protected TestSeedProjectPageModel()
    {
        LocalizationResourceType = typeof(TestSeedProjectResource);
    }
}
