namespace CV3_LSP.Models;

public class Address
{
    private string Street { get; }
    private int HouseNumber { get; }
    private City City { get; }

    public Address(string street, int houseNumber, City city)
    {
        Street = street;
        HouseNumber = houseNumber;
        City = city;
    }
}