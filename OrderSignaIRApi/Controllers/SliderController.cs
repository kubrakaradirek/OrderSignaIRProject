using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSignaIR.BusinessLayer.Abstract;
using OrderSignaIR.DtoLayer.SliderDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SliderController(ISliderService SliderService, IMapper mapper)
        {
            _sliderService = SliderService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SliderList()
        {
            var value = _mapper.Map<List<ResultSliderDto>>(_sliderService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            _sliderService.TAdd(new Slider()
            {
               Description1 = createSliderDto.Description1,
               Description2 = createSliderDto.Description2,
               Description3 = createSliderDto.Description3,
               Title1 = createSliderDto.Title1,
               Title2 = createSliderDto.Title2,
               Title3 = createSliderDto.Title3
            });
            return Ok("Öne çıkan bilgisi başarıyla eklendi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            _sliderService.TDelete(value);
            return Ok("Öne çıkan bilgisi başarıyla silindi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            _sliderService.TUpdate(new Slider()
            {
                SliderId = updateSliderDto.SliderId,
                Description1 = updateSliderDto.Description1,
                Description2 = updateSliderDto.Description2,
                Description3 = updateSliderDto.Description3,
                Title1 = updateSliderDto.Title1,
                Title2 = updateSliderDto.Title2,
                Title3 = updateSliderDto.Title3
            });
            return Ok("Öne çıkan bilgisi başarıyla güncellendi.");
        }

    }
}
