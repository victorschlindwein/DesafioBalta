using DesafioBalta.Models;

namespace DesafioBalta.Repositories
{
    public interface IIbgeRepository
    {
        Task<Ibge> CreateIbgeAsync(Ibge ibge);
    }
}
