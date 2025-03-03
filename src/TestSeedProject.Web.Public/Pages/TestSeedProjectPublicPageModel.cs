using TestSeedProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TestSeedProject.Web.Public.Pages;

/* Inherit your Page Model classes from this class.
 */
public abstract class TestSeedProjectPublicPageModel : AbpPageModel
{
    protected TestSeedProjectPublicPageModel()
    {
        LocalizationResourceType = typeof(TestSeedProjectResource);
    }
}
