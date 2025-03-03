using TestSeedProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestSeedProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TestSeedProjectController : AbpControllerBase
{
    protected TestSeedProjectController()
    {
        LocalizationResource = typeof(TestSeedProjectResource);
    }
}
