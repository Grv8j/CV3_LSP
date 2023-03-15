namespace CV3_LSP.Models;

public interface ICity
{
    string GetCityName();
}

public class City : ICity
{
    private string Name { get; }
    private int PSC { get; set; }
    
    public City(string name, int psc)
    {
        Name = name;
        PSC = psc;
    }

    public string GetCityName() => Name;
}