using AutoMapper;
using UoM.Blazor.Models.DTOs;
using UoM.Blazor.Models;

namespace UoM.Blazor
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           CreateMap<AssayForCreationDto, Assay>();
            
        }
    }
}
