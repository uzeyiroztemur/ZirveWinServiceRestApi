using System;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.SelfHost;

namespace ZirveWinService.Service.Helpers
{
    public class ApiService
    {
        readonly HttpSelfHostServer server;
        readonly HttpSelfHostConfiguration config;

        public ApiService(Uri address)
        {
            config = new HttpSelfHostConfiguration(address);
            config.Routes.MapHttpRoute("DefaultApi", "{controller}/{action}/{id}", new { id = RouteParameter.Optional });
            config.MaxBufferSize = 2147483647;
            config.MaxConcurrentRequests = 2147483647;
            config.MaxReceivedMessageSize = 2147483647;
            config.EnableCors();
            var enableCorsAttribute = new EnableCorsAttribute("*", "Origin, Content-Type, Accept", "GET, PUT, POST, DELETE, OPTIONS");

            config.EnableCors(enableCorsAttribute);
            server = new HttpSelfHostServer(config);
        }

        public void Start()
        {
            if (clsMain.Init())
            {
                server.OpenAsync();
            }
        }

        public void Stop()
        {
            clsMain.DeInit();
            server.CloseAsync().Wait();
            server.Dispose();
        }
    }
}
