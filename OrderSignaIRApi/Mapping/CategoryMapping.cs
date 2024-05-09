using AutoMapper;
using OrderSignaIR.DtoLayer.AboutDto;
using OrderSignaIR.DtoLayer.CategoryDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
