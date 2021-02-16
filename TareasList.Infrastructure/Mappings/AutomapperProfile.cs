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
        }
    }
}
