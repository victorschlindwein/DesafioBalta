using DesafioBalta.Models;

namespace DesafioBalta.Services
{
    public interface IIbgeService
    {
        Task<Ibge> CreateIbgeAsync(Ibge ibge);
        Task<List<Ibge>> GetAllIbgeAsync();
        Task<Ibge> GetByIdAsync(int id);
        Task<List<Ibge>> GetCityIbge(string city);
        Task<List<Ibge>> GetStateIbge(string state);
        Task<bool> Delete(int id);
    }
}
