using DesafioBalta.Models;

namespace DesafioBalta.Repositories
{
    public interface IIbgeRepository
    {
        Task<Ibge> CreateIbgeAsync(Ibge ibge);
        Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken);
        Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken);
        Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken);
        Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken);
        Task<Ibge> UpdateIbge(int id, Ibge ibge);
        Task<bool> Delete(int id);
    }
}
