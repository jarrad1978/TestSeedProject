using Microsoft.EntityFrameworkCore;

namespace TestSeedProject.EntityFrameworkCore;

public class TestSeedProjectDbContextFactory :
    TestSeedProjectDbContextFactoryBase<TestSeedProjectDbContext>
{
    protected override TestSeedProjectDbContext CreateDbContext(
        DbContextOptions<TestSeedProjectDbContext> dbContextOptions)
    {
        return new TestSeedProjectDbContext(dbContextOptions);
    }
}
