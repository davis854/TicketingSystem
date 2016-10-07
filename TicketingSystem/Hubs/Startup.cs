using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(TicketingSystem.Startup))]

namespace TicketingSystem.Hubs
{
    public class Startup 
    {
       public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configruation should go here.
            app.MapSignalR();
        }
    }
}