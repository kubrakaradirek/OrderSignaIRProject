using AutoMapper;
using OrderSignaIR.DtoLayer.AboutDto;
using OrderSignaIR.DtoLayer.BookingDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Mapping
{
    public class BookingMapping:Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
