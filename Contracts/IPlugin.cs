using Microsoft.Extensions.DependencyInjection;

namespace Contracts;

public interface IPlugin
{
    public string Name { get; }
}