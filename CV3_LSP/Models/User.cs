namespace CV3_LSP.Models;

public class User
{
    public int Id { get; }
    public int Age { get; set; }
    public string FirstName { get; }
    public string LastName { get; }
    public Address Address { get; }

    public User(string firstName, string lastName, int age, Address address)
    {
        Id = new Random().Next();
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Address = address;
    }

    public virtual void UpdateUsersAge(int age)
    {
        Age = age >= 0
            ? age
            : throw new ArgumentException($"Provided age: {age} is less than zero");
    }

    public Address GetAddress() => Address;
}