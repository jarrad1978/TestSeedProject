using AutoMapper;
using TestSeedProject.Books;

namespace TestSeedProject;

public class TestSeedProjectApplicationAutoMapperProfile : Profile
{
    public TestSeedProjectApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
