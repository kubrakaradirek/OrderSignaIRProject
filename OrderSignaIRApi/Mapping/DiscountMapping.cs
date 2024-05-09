using AutoMapper;
using OrderSignaIR.DtoLayer.ContactDto;
using OrderSignaIR.DtoLayer.DiscountDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
        }
    }
}
