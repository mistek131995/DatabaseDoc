using System.Reflection;
using Contracts;

namespace MSSQLProvider;

public class Main : IDatabaseProvider
{
    public Main()
    {
        Name = "MSSQL Provider";
        Key = "mssqlprovider";
    }
    public string Name { get; }
    public string Key { get; }

    public string GetConnection()
    {
        return "Database Provider was loaded.";
    }
}