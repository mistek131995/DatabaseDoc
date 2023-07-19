using System.ComponentModel.Composition;
using Contracts;

namespace ScanMSSQLProvider;

[Export(typeof(IScanDatabaseProvider))]
public class Main : IScanDatabaseProvider
{
    public void GetConnection()
    {
        Console.WriteLine("Scan Database Provider was loaded.");
    }
}