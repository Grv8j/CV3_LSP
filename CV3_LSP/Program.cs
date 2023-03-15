

using CV3_LSP.Repository;

IUserRepository userRepository = new UsersRepository();
var users = userRepository.GetUsers();

//Violating of LOD principle - Accessing inner objects
foreach (var user in users)
{
    Console.WriteLine(user.GetAddress().GetCity().Name);
}