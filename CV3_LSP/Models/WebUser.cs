namespace CV3_LSP.Models;

public class WebUser : User
{
    private string EmailAddress { get; }

    public WebUser(string firstName, string lastName, int age, string emailAddress)
        : base(firstName, lastName, age)
    {
        EmailAddress = emailAddress;
    }

    public override void UpdateUsersAge(int age)
    {
        base.UpdateUsersAge(age);
    }
}