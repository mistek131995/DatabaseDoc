using Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace TestPlugins;

public class Main : IPlugin
{
    public Main()
    {
        Name = "My First Plugin";
    }
    public string Name { get; }
}