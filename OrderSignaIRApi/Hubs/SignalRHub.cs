using Microsoft.AspNetCore.SignalR;
using OrderSignaIR.DataAccessLayer.Concrete;

namespace OrderSignaIRApi.Hubs
{
    public class SignalRHub : Hub
    {
        OrderSignaIRContext context = new OrderSignaIRContext();
        public async Task SendCategoryCount()
        {
            var value=context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount",value);
        }
    }
}
