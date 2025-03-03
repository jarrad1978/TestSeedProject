using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace TestSeedProject.Web.Public.Pages;

public class IndexModel : TestSeedProjectPublicPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
