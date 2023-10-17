using DesafioBalta.Context;
using DesafioBalta.Models;
using System;

public class UserService : IUserService
{
    private readonly ApiContext _context;

    public UserService(ApiContext context)
    { _context = context; }

    public async Task<User> CreateAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return user;
    }

    public Task<User> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
