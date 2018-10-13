using demo21SignalR.Services;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace demo21SignalR.Hubs
{
    public class SamplerHub : Hub<IConductorClient>
    {        
        private ISamplerService _samplerService;

        public SamplerHub(ISamplerService samplerService)
        {
            _samplerService = samplerService;
        }
        
    }
}
