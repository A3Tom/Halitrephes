using Halitrephes.Domain.ViewModels;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Halitrephes.Api.Hubs
{
    public class DataPointHub : Hub
    {
        public async Task SendDataPoint(DynamicDataPointVM dynamicDataPoint)
        {
            await Clients.All.SendAsync("RecieveDatapoint", dynamicDataPoint);
        }
    }
}
