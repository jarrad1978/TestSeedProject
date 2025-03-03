using Microsoft.AspNetCore.Builder;
using TestSeedProject;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("TestSeedProject.Web.csproj"); 
await builder.RunAbpModuleAsync<TestSeedProjectWebTestModule>(applicationName: "TestSeedProject.Web");

public partial class Program
{
}
