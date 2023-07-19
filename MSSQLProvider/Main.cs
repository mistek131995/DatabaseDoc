using Contracts;

namespace MSSQLProvider;

public class Main : IDatabaseProvider
{
    public Main()
    {
        Name = "MSSQL Provider";
    }
    public string Name { get; set; }

    public string GetConnection()
    {
        return "Database Provider was loaded.";
    }
    
    
}