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
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(OrderSignaIRContext context) : base(context)
        {
        }

		public void BookingStatusApproved(int id)
		{
		    using var context=new OrderSignaIRContext();
			var values=context.Bookings.Find(id);
			values.Description = "Rezervasyon Onaylandı";
			context.SaveChanges();
		}

		public void BookingStatusCancelled(int id)
		{
			using var context = new OrderSignaIRContext();
			var values = context.Bookings.Find(id);
			values.Description = "Rezervasyon İptal Edildi";
			context.SaveChanges();
		}
	}
}
