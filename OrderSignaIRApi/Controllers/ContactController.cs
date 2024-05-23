﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSignaIR.BusinessLayer.Abstract;
using OrderSignaIR.DtoLayer.ContactDto;
using OrderSignaIR.EntityLayer.Entities;

namespace OrderSignaIRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		private readonly IContactService _contactService;
		private readonly IMapper _mapper;

		public ContactController(IContactService contactService, IMapper mapper)
		{
			_contactService = contactService;
			_mapper = mapper;
		}
		[HttpGet]
		public IActionResult ContactList()
		{
			var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateContact(CreateContactDto createContactDto)
		{
			_contactService.TAdd(new Contact()
			{
				FooterDescription = createContactDto.FooterDescription,
				Location = createContactDto.Location,
				Mail = createContactDto.Mail,
				Phone = createContactDto.Phone,
				FooterTitle = createContactDto.FooterTitle,
				OpenDays = createContactDto.OpenDays,
				OpenDaysDescription = createContactDto.OpenDaysDescription,
				OpenHours = createContactDto.OpenHours
			});
			return Ok("İletişim bilgisi başarıyla eklendi.");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteContact(int id)
		{
			var value = _contactService.TGetById(id);
			_contactService.TDelete(value);
			return Ok("İletişim bilgisi başarıyla silindi.");
		}
		[HttpGet("{id}")]
		public IActionResult GetContact(int id)
		{
			var value = _contactService.TGetById(id);
			return Ok(value);
		}
		[HttpPut]
		public IActionResult UpdateContact(UpdateContactDto updateContactDto)
		{
			_contactService.TUpdate(new Contact()
			{
				ContactId = updateContactDto.ContactId,
				FooterDescription = updateContactDto.FooterDescription,
				Location = updateContactDto.Location,
				Mail = updateContactDto.Mail,
				Phone = updateContactDto.Phone,
				FooterTitle = updateContactDto.FooterTitle,
				OpenDays = updateContactDto.OpenDays,
				OpenDaysDescription = updateContactDto.OpenDaysDescription,
				OpenHours = updateContactDto.OpenHours
			});
			return Ok("İletişim bilgisi başarıyla güncellendi.");
		}

	}
}
