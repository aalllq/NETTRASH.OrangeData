using System;
using System.Reflection;
using NETTRASH.OrangeData.Nebula.API;

namespace NETTRASH.OrangeData.Nebula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"NETTRASH.OrangeData.Nebula Console Util v{Assembly.GetExecutingAssembly().GetName().Version.ToString()}\n");
            Arguments prms = new Arguments(args);
            if (prms.Valid)
            {
                Console.WriteLine(prms.Execute());
            }
            else
            {
                Console.WriteLine($"Invalid arguments\n{prms.Message}\n{prms.GetUseString()}\n");
            }
        }
    }
}
