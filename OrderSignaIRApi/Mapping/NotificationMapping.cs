using AutoMapper;
using OrderSignaIR.DtoLayer.NotificationDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Mapping
{
	public class NotificationMapping:Profile
	{
        public NotificationMapping()
        {
			CreateMap<Notification, ResultNotificationDto>().ReverseMap();
			CreateMap<Notification, CreateNotificationDto>().ReverseMap();
			CreateMap<Notification, UpdateNotificationDto>().ReverseMap();
		}
    }
}
