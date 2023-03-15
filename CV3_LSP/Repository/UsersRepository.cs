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
            new User("Tomas", "Jiny", 1, new Address("Jonasova", 100, new City("Ostrava", 70800))),
            new User("Johnas", "Tomas", 25, new Address("Nevimova", 145, new City("Trinec", 73961))),
            new WebUser("Poruseny", "Uzivatel", 20, new Address("Harazimova", 4568, new City("Praha", 10000)), "porusenyuzivatel@gmail.com")
        };
    }
}