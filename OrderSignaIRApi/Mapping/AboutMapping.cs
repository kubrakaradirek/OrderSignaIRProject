using AutoMapper;
using OrderSignaIR.DtoLayer.AboutDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
                CreateMap<About,ResultAboutDto>().ReverseMap();
                CreateMap<About,CreateAboutDto>().ReverseMap();
                CreateMap<About,GetAboutDto>().ReverseMap();
                CreateMap<About,UpdateAboutDto>().ReverseMap();
        }
    }
}
