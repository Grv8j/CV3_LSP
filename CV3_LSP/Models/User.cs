namespace CV3_LSP.Models;

public interface IUser
{
    void UpdateUsersAge(int age);
    string GetUserCityName();
}

public class User : IUser
{
    public int Id { get; }
    public int Age { get; set; }
    public string FirstName { get; }
    public string LastName { get; }
    private IAddress Address { get; }

    public User(string firstName, string lastName, int age, IAddress address)
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

    public string GetUserCityName() => Address.GetCity().GetCityName();
}