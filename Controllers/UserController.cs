using LearningDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetAll()
    {
        var users = await _userService.GetUsersAsync();
        return Ok(users);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<User>> GetById(int id)
    {
        var user = await _userService.GetUserByIdAsync(id);
        if (user == null) return NotFound();
        return Ok(user);
    }

    
}
