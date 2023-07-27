using AutoMapper;
using UoM.Blazor.Models;
using UoM.Blazor.Models.DisplayModels;
using UoM.Blazor.Models.Responses;

namespace UoM.Blazor
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           CreateMap<AssayDisplayModel, AssayModel>();
           CreateMap<AssayDisplayModel, AssayModel>().ReverseMap();
           CreateMap<AssayDisplayModel, AssayModel>();
        }
    }
}
