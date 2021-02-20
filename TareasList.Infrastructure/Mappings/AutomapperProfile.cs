using AutoMapper;
using TareasList.Core.DTOS;
using TareasList.Core.Entities;

namespace TareasList.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Work, WorkDTO>().ReverseMap();
<<<<<<< HEAD
            CreateMap<User, UserDTO>().ReverseMap();

=======
>>>>>>> f0694bffa52d050b0edc9f338752aa7abac3884b
        }
    }
}
