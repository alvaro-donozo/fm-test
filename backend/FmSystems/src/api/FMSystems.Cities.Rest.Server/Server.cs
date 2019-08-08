namespace FMSystems.Cities.Rest.Server
{
    using System.IO;
    using Microsoft.AspNetCore.Hosting;
    using FMSystems.Cities.Rest.Api;

    public static class Server
    {
        public static void RunServer(string url)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls(urls: url)
                .Build();
            host.Run();
        }
    }
}
