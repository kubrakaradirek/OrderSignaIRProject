using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSignaIR.BusinessLayer.Abstract;
using OrderSignaIR.DtoLayer.MessageDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessageController : ControllerBase
	{
		private readonly IMessageService _meesageService;

		public MessageController(IMessageService MessageService)
		{
			_meesageService = MessageService;
		}
		
		[HttpGet]
		public IActionResult MessageList()
		{
			var values = _meesageService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMessage(CreateMessageDto createMessageDto)
		{
			Message Message = new Message()
			{
				Mail = createMessageDto.Mail,
				MessageContent = createMessageDto.MessageContent,
				MessageSendDate = createMessageDto.MessageSendDate,
				NameSurname = createMessageDto.NameSurname,
				Phone = createMessageDto.Phone,
				Status = false,
				Subject = createMessageDto.Subject
			};
			_meesageService.TAdd(Message);
			return Ok("Mesaj başarılı bir şekilde gönderildi.");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteMessage(int id)
		{
			var value = _meesageService.TGetById(id);
			_meesageService.TDelete(value);
			return Ok("Mesaj başarılı bir şekilde silindi.");
		}
		[HttpPut]
		public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
		{
			Message Message = new Message()
			{
				Mail = updateMessageDto.Mail,
				MessageContent = updateMessageDto.MessageContent,
				MessageSendDate = updateMessageDto.MessageSendDate,
				NameSurname = updateMessageDto.NameSurname,
				Phone = updateMessageDto.Phone,
				Status = false,
				Subject = updateMessageDto.Subject
			};
			_meesageService.TUpdate(Message);
			return Ok("Mesaj başarılı bir şekilde güncellendi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetMessage(int id)
		{
			var value = _meesageService.TGetById(id);
			return Ok(value);
		}
	}
}
