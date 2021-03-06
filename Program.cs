using ConsoleAppFramework;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

// Entrypoint, create from the .NET Core Console App.
class Program : ConsoleAppBase // inherit ConsoleAppBase
{
    static async Task Main(string[] args)
    {
        // target T as ConsoleAppBase.
        await Host.CreateDefaultBuilder().RunConsoleAppFrameworkAsync<Program>(args);
    }

    // allows void/Task return type, parameter is automatically binded from string[] args.
    public void Run(string name, int repeat = 3)
    {
        for (int i = 0; i < repeat; i++)
        {
            Console.WriteLine($"Hello My ConsoleApp from {name}");
        }
    }
}
