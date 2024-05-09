using AutoMapper;
using OrderSignaIR.DtoLayer.SocialMediaDto;
using OrderSignaIR.DtoLayer.TestimonialDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Mapping
{
    public class TestimonialMapping:Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
