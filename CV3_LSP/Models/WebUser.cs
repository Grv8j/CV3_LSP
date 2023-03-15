namespace CV3_LSP.Models;

public class WebUser : User
{
    private string EmailAddress { get; }

    public WebUser(string firstName, string lastName, int age, Address address, string emailAddress)
        : base(firstName, lastName, age, address)
    {
        EmailAddress = emailAddress;
    }

    public override void UpdateUsersAge(int age)
    {
        base.UpdateUsersAge(age);
    }
}