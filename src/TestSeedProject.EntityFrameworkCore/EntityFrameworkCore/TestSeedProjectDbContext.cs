using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace TestSeedProject.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class TestSeedProjectDbContext : TestSeedProjectDbContextBase<TestSeedProjectDbContext>
{
    public TestSeedProjectDbContext(DbContextOptions<TestSeedProjectDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Both);

        base.OnModelCreating(builder);
    }
}
