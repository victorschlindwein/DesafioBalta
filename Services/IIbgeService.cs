using DesafioBalta.Models;

namespace DesafioBalta.Services
{
    public interface IIbgeService
    {
        Task<Ibge> CreateIbgeAsync(Ibge ibge);
    }
}
