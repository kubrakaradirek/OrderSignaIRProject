using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSignaIR.BusinessLayer.Abstract;
using OrderSignaIR.DtoLayer.MenuTableDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTablesController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;

        public MenuTablesController(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }
        [HttpGet("MenuTableCount")]
        public ActionResult MenuTableCount()
        {
            return Ok(_menuTableService.TMenuTableCount());
        }
        [HttpGet]
        public IActionResult MenuTableList()
        {
            var values = _menuTableService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            MenuTable MenuTable = new MenuTable()
            {
                Name= createMenuTableDto.Name,
                Status=false
            };
            _menuTableService.TAdd(MenuTable);
            return Ok("Masa başarılı bir şekilde eklendi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMenuTable(int id)
        {
            var value = _menuTableService.TGetById(id);
            _menuTableService.TDelete(value);
            return Ok("Masa başarılı bir şekilde silindi.");
        }
        [HttpPut]
        public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
        {
            MenuTable MenuTable = new MenuTable()
            {
                MenuTableId = updateMenuTableDto.MenuTableId,
                Name = updateMenuTableDto.Name,
                Status = false
            };
            _menuTableService.TUpdate(MenuTable);
            return Ok("Masa başarı bir şekilde güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetMenuTable(int id)
        {
            var value = _menuTableService.TGetById(id);
            return Ok(value);
        }
    }
}
