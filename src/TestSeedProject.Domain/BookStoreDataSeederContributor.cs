using System;
using System.Threading.Tasks;
using TestSeedProject.Books;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.MultiTenancy;

namespace TestSeedProject;

public class TestSeedProjectDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Book, Guid> _bookRepository;
    private readonly ICurrentTenant _currentTenant;

    public TestSeedProjectDataSeederContributor(IRepository<Book, Guid> bookRepository,
        ICurrentTenant currentTenant)
    {
        _bookRepository = bookRepository;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (!_currentTenant.IsAvailable)
        {
            Console.WriteLine("⚠️ Skipping Book seeding: No tenant detected.");
            return; // ⛔ Exit early if we're not in a tenant database
        }
        Console.Write($"current tenant: {_currentTenant.Id}");

        using (_currentTenant.Change(context?.TenantId))
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertAsync(
                    new Book
                    {
                        Name = "1984",
                        Type = BookType.Dystopia,
                        PublishDate = new DateTime(1949, 6, 8),
                        Price = 19.84f
                    },
                    autoSave: true
                );

                await _bookRepository.InsertAsync(
                    new Book
                    {
                        Name = "The Hitchhiker's Guide to the Galaxy",
                        Type = BookType.ScienceFiction,
                        PublishDate = new DateTime(1995, 9, 27),
                        Price = 42.0f
                    },
                    autoSave: true
                );    
            }
        }
    }
}
