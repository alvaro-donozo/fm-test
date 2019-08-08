namespace FMSystems.Cities.Rest.Server
{
    using System;
    using System.Configuration;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var url = ConfigurationManager.AppSettings["serviceUrl"];
                Server.RunServer(url);
            }
            catch(Exception e)
            {
                Console.WriteLine($"There is a problem with the server: ", e);
            }
        }
    }
}
