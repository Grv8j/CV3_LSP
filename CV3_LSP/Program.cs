

using CV3_LSP.Repository;

IUserRepository userRepository = new UsersRepository();
var users = userRepository.GetUsers();
