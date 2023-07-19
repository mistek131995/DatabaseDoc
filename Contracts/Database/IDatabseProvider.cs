namespace Contracts;

public interface IDatabaseProvider
{
    public string Name { get; set; }
    string GetConnection();
}