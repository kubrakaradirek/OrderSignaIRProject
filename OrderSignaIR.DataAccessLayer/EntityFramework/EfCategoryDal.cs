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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(OrderSignaIRContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context=new OrderSignaIRContext();
            return context.Categories.Where(x=>x.Status==true).Count();
        }

        public int CategoryCount()
        {
            using var context = new OrderSignaIRContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new OrderSignaIRContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
