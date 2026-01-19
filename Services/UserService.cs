using LearningDotNet.Data;
using LearningDotNet.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

public class UserService : IUserService
{
    private readonly AppDbContext _context;
    public UserService(AppDbContext context)
    {
        _context = context;
    }

    // get all users
    public async Task<List<User>> GetUsersAsync()
    {
        return await _context.Users.ToListAsync();
    }

    // get user by id
    public async Task<User?> GetUserByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }


}
