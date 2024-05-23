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
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        public EfDiscountDal(OrderSignaIRContext context) : base(context)
        {
        }

		public void ChangeStatusToFalse(int id)
		{
			using var context = new OrderSignaIRContext();
			var value = context.Discounts.Find(id);
			value.Status= false;
			context.SaveChanges();
		}

		public void ChangeStatusToTrue(int id)
		{
			using var context = new OrderSignaIRContext();
			var value = context.Discounts.Find(id);
			value.Status = true;
			context.SaveChanges();
		}

		public List<Discount> GetListByStatusTrue()
		{
			using var context=new OrderSignaIRContext();
			var value=context.Discounts.Where(z=>z.Status==true).ToList();
			return value;
		}
	}
}
