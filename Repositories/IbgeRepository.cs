using DesafioBalta.Context;
using DesafioBalta.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DesafioBalta.Repositories
{
    public class IbgeRepository : IIbgeRepository
    {
        private readonly ApiContext _context;

        public IbgeRepository(ApiContext context)
            => _context = context;

        public async Task<Ibge> CreateIbgeAsync(Ibge ibge)
        {
            await _context.AddAsync(ibge);
            await _context.SaveChangesAsync();

            return ibge;
        }

        public async Task<List<Ibge>> GetAllIbgeAsync(CancellationToken cancellationToken)
        {
            var ibges = await _context.Ibges.ToListAsync(cancellationToken);
            return ibges;
        }

        public async Task<Ibge> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            var data = await _context.Ibges.FirstOrDefaultAsync(x  => x.Id == id, cancellationToken);
            return data;
        }

        public async Task<List<Ibge>> GetCityIbge(string city, CancellationToken cancellationToken)
        {
            var cityIbgeList = await _context.Ibges.Where(x => x.City.Contains(city)).ToListAsync(cancellationToken);
            return cityIbgeList;
        }

        public async Task<List<Ibge>> GetStateIbge(string state, CancellationToken cancellationToken)
        {
            var stateIbgeList = await _context.Ibges.Where(x => x.State.Contains(state)).ToListAsync(cancellationToken);
            return stateIbgeList;
        }

        public async Task<Ibge> UpdateIbge(int id, Ibge ibge)
        {
            var data = await _context.Ibges.FindAsync(id);

            if (data == null)
                return null;

            data.City = ibge.City;
            data.State = ibge.State;
                   
            _context.Update(data);
            await _context.SaveChangesAsync();

            return data;
        }

        public async Task<bool> Delete(int id)
        {
            var data = await _context.Ibges.FirstOrDefaultAsync(x => x.Id == id);
            if (data == null)
                return false;

            _context.Ibges.Remove(data);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
