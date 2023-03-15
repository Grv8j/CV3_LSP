namespace CV3_LSP.Models;

public class Address
{
    private string Street { get; }
    private int HouseNumber { get; }
    public City _City { get; }

    public Address(string street, int houseNumber, City city)
    {
        Street = street;
        HouseNumber = houseNumber;
        _City = city;
    }

    public City GetCity() => _City;
}