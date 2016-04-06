


using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(Chat_Using_ASP.NET.Startup))]
namespace Chat_Using_ASP.NET
{

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}