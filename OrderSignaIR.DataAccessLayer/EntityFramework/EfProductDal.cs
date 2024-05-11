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
    }
}
