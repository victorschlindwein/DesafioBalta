using DesafioBalta.Models;
using DesafioBalta.Repositories;
using DesafioBalta.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
        => _userRepository = userRepository;

    public async Task<User> CreateAsync(User user)
        => await _userRepository.CreateAsync(user);

    public async Task<User> LoginUserAsync(User user)
        => await _userRepository.LoginUserAsync(user);

    public async Task<List<User>> GetAllAsync()
        => await _userRepository.GetAllAsync();
}
