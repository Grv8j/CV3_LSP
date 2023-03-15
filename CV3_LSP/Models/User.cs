namespace CV3_LSP.Models;

public class User
{
    private int Id { get; }
    private int Age { get; set; }
    private string FirstName { get; }
    private string LastName { get; }

    public User(string firstName, string lastName, int age)
    {
        Id = new Random().Next();
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public virtual void UpdateUsersAge(int age)
    {
        Age = age >= 0
            ? age
            : throw new ArgumentException($"Provided age: {age} is less than zero");
    }
}