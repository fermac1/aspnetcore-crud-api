using LearningDotNet.Models;

public interface IUserService
{
    // get all users
    Task<List<User>> GetUsersAsync();

    // get user by id
    Task<User?> GetUserByIdAsync(int id);

    // create user
    Task<User> CreateUserAsync(User user);

    // update user
    Task<bool> UpdateUserAsync(User user);

    // delete user
    Task<bool> DeleteUserAsync(int id);
}
