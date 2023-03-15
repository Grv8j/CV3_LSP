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
        if (age < 18)
        {
            throw new Exception("User should be older than 18");
        }
        
        base.UpdateUsersAge(age);
    }
}