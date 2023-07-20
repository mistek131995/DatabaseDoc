namespace Contracts;

public interface IDatabaseProvider
{
    public string Name { get; }
    public string Key { get; }
    string GetConnection();
}