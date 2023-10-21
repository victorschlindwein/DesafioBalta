using DesafioBalta.Models;
using DesafioBalta.Repositories;

namespace DesafioBalta.Services
{
    public class IbgeService : IIbgeService
    {
        private readonly IIbgeRepository _ibgeRepository;

        public IbgeService(IIbgeRepository ibgeRepository)
            => _ibgeRepository = ibgeRepository;

        public async Task<Ibge> CreateIbgeAsync(Ibge ibge)
            => await _ibgeRepository.CreateIbgeAsync(ibge);

        public async Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken)
            => await _ibgeRepository.GetAllIbgeAsync(cancellationToken);

        public async Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken)
            => await _ibgeRepository.GetByIdAsync(id, cancellationToken);

        public async Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken)
            => await _ibgeRepository.GetStateIbge(state, cancellationToken);

        public async Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken)
            => await _ibgeRepository.GetCityIbge(city, cancellationToken);

        public async Task<Ibge> UpdateIbge(int id, Ibge ibge)
            => await _ibgeRepository.UpdateIbge(id, ibge);

        public async Task<bool> Delete(int id)
        {
            var isDeleted = await _ibgeRepository.Delete(id);
            return isDeleted;
        }
    }
}
