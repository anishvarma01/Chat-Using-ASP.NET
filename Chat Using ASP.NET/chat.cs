using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.IO;

namespace Chat_Using_ASP.NET
{
    public class chat : Hub
    {
        public void Send(String name, String message)
        {
            Clients.All.broadcastMessage(name, message);
        }
        


    }
    }