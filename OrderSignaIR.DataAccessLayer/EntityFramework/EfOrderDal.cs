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
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public EfOrderDal(OrderSignaIRContext context) : base(context)
        {

        }

        public int ActiveOrderCount()
        {
            using var context = new OrderSignaIRContext();
            return context.Orders.Where(x=>x.Description== "Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            using var context = new OrderSignaIRContext();
            return context.Orders.OrderByDescending(x=>x.OrderId).Take(1).Select(y=>y.TotalPrice).FirstOrDefault();
        }

        public int TotalOrderCount()
        {
            using var context = new OrderSignaIRContext();  
            return context.Orders.Count();
        }
    }
    
}
