using LearningDotNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IUserService
{
    // get all users
    Task<List<User>> GetUsersAsync();

    // get user by id
    Task<User?> GetUserByIdAsync(int id);

   
}
