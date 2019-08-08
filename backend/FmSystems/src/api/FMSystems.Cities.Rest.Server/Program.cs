namespace FMSystems.Cities.Rest.Server
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var url = "http://localhost:8000";
                Server.RunServer(url);
            }
            catch(Exception e)
            {
                Console.WriteLine($"There is a problem with the server: ", e);
            }
        }
    }
}
