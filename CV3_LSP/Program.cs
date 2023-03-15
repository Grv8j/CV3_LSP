

using CV3_LSP.Repository;

IUserRepository userRepository = new UsersRepository();
var users = userRepository.GetUsers();

//UPDATE ALL USER AGES
foreach (var user in users)
{
    Console.WriteLine($"User: {user.FirstName} {user.LastName} Age: {user.Age}");
    user.UpdateUsersAge(15);
    Console.WriteLine($"AFTER UPDATE: User: {user.FirstName} {user.LastName} Age: {user.Age}");
}