using Microsoft.EntityFrameworkCore;
using TestSeedProject.Books;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.MultiTenancy;

namespace TestSeedProject.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class TestSeedProjectTenantDbContext : TestSeedProjectDbContextBase<TestSeedProjectTenantDbContext>
{
    public DbSet<Book> Books { get; set; }
    public TestSeedProjectTenantDbContext(DbContextOptions<TestSeedProjectTenantDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Tenant);
        ConfigureBooks(builder);
        base.OnModelCreating(builder);
    }

    private void ConfigureBooks(ModelBuilder builder)
    {
        builder.Entity<Book>(b =>
        {
            b.ToTable(TestSeedProjectConsts.DbTablePrefix + "Books",
                TestSeedProjectConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });
    }
}
