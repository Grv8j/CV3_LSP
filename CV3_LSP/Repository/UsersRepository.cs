using CV3_LSP.Models;

namespace CV3_LSP.Repository;

public interface IUserRepository
{
    public IList<User> GetUsers();
}

public class UsersRepository : IUserRepository
{
    public IList<User> GetUsers()
    {
        return new List<User>
        {
            new User("Tomas", "Jiny", 1),
            new User("Johnas", "Tomas", 25),
            new WebUser("Poruseny", "Uzivatel", 20, "porusenyuzivatel@gmail.com")
        };
    }
}