using System;
using System.Threading;
using Topshelf;
using ZirveWinService.Service.Helpers;
using ZirveWinService.Service.Utils;

namespace ZirveWinService.Service
{
    internal class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureUtils.TurkishCulture;
            Thread.CurrentThread.CurrentUICulture = CultureUtils.TurkishCulture;

            ConfigurationUtils.LoadConfiguration();

            var serviceConfig = HostFactory.Run(x =>
            {
                x.Service<ApiService>(s =>
                {
                    s.ConstructUsing(name => new ApiService(new Uri(ConfigurationUtils.ServiceUrl)));
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();
                x.StartManually();
                x.SetDescription("Zirve Web API Windows Service");
                x.SetDisplayName("ZirveWinService");
                x.SetServiceName("ZirveWinService");
            });
        }
    }
}
