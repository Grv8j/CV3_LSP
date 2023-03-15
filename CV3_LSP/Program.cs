

using CV3_LSP.Repository;

IUserRepository userRepository = new UsersRepository();
var users = userRepository.GetUsers();

//UPDATE ALL USER AGES
foreach (var user in users)
{
    user.UpdateUsersAge(15);
}