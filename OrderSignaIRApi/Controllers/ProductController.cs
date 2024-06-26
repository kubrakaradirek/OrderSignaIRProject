﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderSignaIR.BusinessLayer.Abstract;
using OrderSignaIR.DataAccessLayer.Concrete;
using OrderSignaIR.DtoLayer.ProductDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService ProductService, IMapper mapper)
        {
            _productService = ProductService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }
        [HttpGet("TProductAveragePriceByHamburger")]
        public IActionResult TProductAveragePriceByHamburger()
        {
            return Ok(_productService.TProductAveragePriceByHamburger());
        }
        
        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.TProductCountByCategoryNameHamburger());
        }
        [HttpGet("TotalPriceSpaghettiCategory")]
        public IActionResult TotalPriceSpaghettiCategory()
        {
            return Ok(_productService.TTotalPriceSpaghettiCategory());
        }
        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }
        [HttpGet("ProductPriceByMeatballBurger")]
        public IActionResult ProductPriceByMeatballBurger()
        {
            return Ok(_productService.TProductPriceByMeatballBurger());
        }
        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());
        }
        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }
        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.TProductNameByMaxPrice());
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory() 
        {
            var context = new OrderSignaIRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductId = y.ProductId,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            });
            return Ok(values.ToList());
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
               Description = createProductDto.Description,
               ImageUrl = createProductDto.ImageUrl,
               Price = createProductDto.Price,
               ProductName = createProductDto.ProductName,
               ProductStatus = createProductDto.ProductStatus,
               CategoryId=createProductDto.CategoryId
               
            });
            return Ok("Ürün bilgisi başarıyla eklendi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün bilgisi başarıyla silindi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus,
                ProductId = updateProductDto.ProductId,
                CategoryId = updateProductDto.CategoryId
            });
            return Ok("Ürün Bilgisi Güncellendi");
        }

    }
}
