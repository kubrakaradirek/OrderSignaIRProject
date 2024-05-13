using Microsoft.EntityFrameworkCore;
using OrderSignaIR.DataAccessLayer.Abstract;
using OrderSignaIR.DataAccessLayer.Concrete;
using OrderSignaIR.DataAccessLayer.Repositories;
using OrderSignaIR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(OrderSignaIRContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context=new OrderSignaIRContext();
            var values=context.Products.Include(x=>x.Category).ToList();
            return values;
        }

        public int ProductCount()
        {
            using var context=new OrderSignaIRContext();    
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new OrderSignaIRContext();
            return context.Products.Where(x=>x.CategoryId==(context.Categories.Where(y=>y.CategoryName=="İçecek").Select(z=>z.CategoryId).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new OrderSignaIRContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new OrderSignaIRContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            using var context = new OrderSignaIRContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {
            using var context = new OrderSignaIRContext();
            return context.Products.Average(x => x.Price);
        }

        public decimal ProductAveragePriceByHamburger()
        {
            using var context = new OrderSignaIRContext();
            return context.Products.Where(x=>x.CategoryId==(context.Categories.Where(y=>y.CategoryName=="Hamburger").Select(z=>z.CategoryId).FirstOrDefault())).Average(w=>w.Price);
        }
    }
}
