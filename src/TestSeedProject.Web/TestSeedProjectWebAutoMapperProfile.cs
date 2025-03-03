using AutoMapper;
using TestSeedProject.Books;

namespace TestSeedProject.Web;

public class TestSeedProjectWebAutoMapperProfile : Profile
{
    public TestSeedProjectWebAutoMapperProfile()
    {
        CreateMap<BookDto, CreateUpdateBookDto>();
        
        //Define your object mappings here, for the Web project
    }
}
