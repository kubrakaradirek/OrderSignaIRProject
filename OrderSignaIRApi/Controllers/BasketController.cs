using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSignaIR.BusinessLayer.Abstract;

namespace OrderSignaIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }
        [HttpGet]
        public IActionResult GetBasketByMenuTableId(int id)
        {
            var values=_basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }
    }
}
