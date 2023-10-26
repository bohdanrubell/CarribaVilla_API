using AutoMapper;
using CarribaVilla_ASP_API.Models;
using CarribaVilla_ASP_API.Models.Dto;

namespace CarribaVilla_ASP_API
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();
            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}
