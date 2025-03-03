using Microsoft.EntityFrameworkCore;

namespace TestSeedProject.EntityFrameworkCore;

public class TestSeedProjectTenantDbContextFactory :
    TestSeedProjectDbContextFactoryBase<TestSeedProjectTenantDbContext>
{
    protected override TestSeedProjectTenantDbContext CreateDbContext(
        DbContextOptions<TestSeedProjectTenantDbContext> dbContextOptions)
    {
        return new TestSeedProjectTenantDbContext(dbContextOptions);
    }
}
