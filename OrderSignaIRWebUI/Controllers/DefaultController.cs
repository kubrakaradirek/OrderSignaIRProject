using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderSignaIR.DtoLayer.MessageDto;
using System.Net.Http;
using System.Text;

namespace OrderSignaIRWebUI.Controllers
{
    public class DefaultController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;
		public DefaultController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return PartialView();
        }
		[HttpPost]
		public async Task<IActionResult> SendMessage(CreateMessageDto createMessageDto)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createMessageDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7085/api/Message", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
