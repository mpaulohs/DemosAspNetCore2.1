using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo21SignalR.Hubs
{
    public class HitCounterHub : Hub
    {
        //static int _hitCount = 0;

        //private void ShowHitCount()
        //{
        //    Clients.All.SendAsync("hitReceived", _hitCount);
        //}

        //public override Task OnConnectedAsync()
        //{
        //    _hitCount += 1;
        //    ShowHitCount();
        //    return base.OnConnectedAsync(); 
        //}
    }
}
