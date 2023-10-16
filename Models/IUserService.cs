using DesafioBalta.Models;

namespace DesafioBalta.Models
{
    public interface IUserService
    {
        Task<User> CreateAsync(User user);
    }
}