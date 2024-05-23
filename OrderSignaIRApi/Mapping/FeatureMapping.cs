using AutoMapper;
using OrderSignaIR.DtoLayer.DiscountDto;
using OrderSignaIR.DtoLayer.SliderDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Mapping
{
    public class SliderMapping:Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
        }
    }
}
