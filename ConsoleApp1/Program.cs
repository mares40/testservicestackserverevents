using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblies = new List<Assembly>()
            {
                typeof(ApiService).Assembly
            }.ToArray();
            using (var appHost = new ApiHost("Test API", assemblies))
            {
                appHost.Init().Start("http://*:10256/");
                Console.WriteLine("Started. Press a key to exit");
                Console.ReadLine();
            }
        }
    }
}
