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
	public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
	{
		public EfNotificationDal(OrderSignaIRContext context) : base(context)
		{
		}

		public List<Notification> GetAllNotificationByFalse()
		{
			using var context = new OrderSignaIRContext();
		    return context.Notifications.Where(x=>x.Status==false).ToList();
		}

		public int NotificationCountByStatusFalse()
		{
			using var context = new OrderSignaIRContext();
			return context.Notifications.Where(x=>x.Status==false).Count();
		}

        public void NotificationStatusChangeToFalse(int id)
        {
            using var context = new OrderSignaIRContext();
			var value = context.Notifications.Find(id);
			value.Status = false;
			context.SaveChanges();
        }

        public void NotificationStatusChangeToTrue(int id)
        {
            using var context = new OrderSignaIRContext();
            var value = context.Notifications.Find(id);
            value.Status = true;
            context.SaveChanges();
        }
    }
}
