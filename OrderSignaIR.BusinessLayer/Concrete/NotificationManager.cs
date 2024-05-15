using OrderSignaIR.BusinessLayer.Abstract;
using OrderSignaIR.DataAccessLayer.Abstract;
using OrderSignaIR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSignaIR.BusinessLayer.Concrete
{
	public class NotificationManager : INotificationService
	{
		private readonly INotificationDal _notificationDal;

		public NotificationManager(INotificationDal NotificationDal)
		{
			_notificationDal = NotificationDal;
		}

		public void TAdd(Notification entity)
		{
			_notificationDal.Add(entity);
		}

		public void TDelete(Notification entity)
		{
			_notificationDal.Delete(entity);
		}

		public Notification TGetById(int id)
		{
			return _notificationDal.GetById(id);
		}

		public List<Notification> TGetListAll()
		{
			return _notificationDal.GetListAll();
		}

		public int TNotificationCountByStatusFalse()
		{
			return _notificationDal.NotificationCountByStatusFalse();
		}

		public void TUpdate(Notification entity)
		{
			_notificationDal.Update(entity);
		}
	}
}
