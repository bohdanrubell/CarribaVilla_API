using AutoMapper;
using CarribaVilla_Web.Models.Dto;
using CarribaVilla_Web.Models.ViewModel;

namespace CarribaVilla_Web
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumberDTO, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaNumberUpdateDTO>().ReverseMap();

            CreateMap<VillaUpdateViewModel, VillaNumberUpdateDTO>();
            CreateMap<VillaNumberCreateVM, VillaNumberCreateDTO>();
        }
    }
}
