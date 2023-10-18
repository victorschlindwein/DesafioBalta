using DesafioBalta.Models;
using DesafioBalta.Repositories;
using System.ComponentModel;

namespace DesafioBalta.Services
{
    public class IbgeService : IIbgeService
    { 
        private readonly IIbgeRepository _ibgeRepository;

        public IbgeService(IIbgeRepository ibgeRepository)
        {
            _ibgeRepository = ibgeRepository;
        }

        public async Task<Ibge> CreateIbgeAsync(Ibge ibge)
        {
            return await _ibgeRepository.CreateIbgeAsync(ibge);
        }

        public async Task<List<Ibge>> GetAllIbgeAsync()
        {
            return await _ibgeRepository.GetAllIbgeAsync();
        }

        public async Task<Ibge> GetByIdAsync(int id)
        {
            return await _ibgeRepository.GetByIdAsync(id);
        }
        public async Task<List<Ibge>> GetStateIbge(string state)
        {
            return await _ibgeRepository.GetStateIbge(state);
        }

        public async Task<List<Ibge>> GetCityIbge(string city)
        {
            return await _ibgeRepository.GetCityIbge(city);
        }

        public async Task<bool> Delete(int id)
        {
            var isDeleted = await _ibgeRepository.Delete(id);
            return isDeleted;
        }
    }
}
