namespace CV3_LSP.Models;

public interface IAddress
{
    ICity GetCity();
}

public class Address : IAddress
{
    private string Street { get; }
    private int HouseNumber { get; }
    private ICity _City { get; }

    public Address(string street, int houseNumber, ICity city)
    {
        Street = street;
        HouseNumber = houseNumber;
        _City = city;
    }

    public ICity GetCity() => _City;
}