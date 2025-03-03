using TestSeedProject.Localization;
using Volo.Abp.Application.Services;

namespace TestSeedProject;

/* Inherit your application services from this class.
 */
public abstract class TestSeedProjectAppService : ApplicationService
{
    protected TestSeedProjectAppService()
    {
        LocalizationResource = typeof(TestSeedProjectResource);
    }
}
