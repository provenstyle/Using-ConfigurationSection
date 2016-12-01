using System;
using System.Configuration;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            var configSection = ConfigurationManager.GetSection("FizzBuzz") as UrlsSection;

            if (configSection == null)
                Console.WriteLine("Failed to load ConfigurationSection.");
            else
            {
                Console.WriteLine("The urls collection of app.config:");
                foreach (UrlConfigElement url in configSection.Urls)
                {
                    Console.WriteLine("  Name={0} URL={1} Port={2}", url.Name, url.Url, url.Port);
                }
            }
            Console.ReadLine();
        }
    }
}
