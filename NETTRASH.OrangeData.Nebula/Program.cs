using System;
using System.Reflection;
using NETTRASH.OrangeData.Nebula.Interfaces;

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
                ICommand cmd = prms.GetCommand();
                if (cmd != null)
                {
                    ICommandResult result = cmd.Execute();
                    Console.WriteLine($"Executed: {(result.Success ? "Success" : "Fail")} {result.Message}");
                    Console.WriteLine($"\n{cmd.Log}");
                }
                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
            else
            {
                Console.WriteLine($"Invalid arguments\n{prms.Message}\n{prms.GetUseString()}\n");
            }
        }
    }
}
