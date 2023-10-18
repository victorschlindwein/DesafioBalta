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
        {
            _context = context;
        }

        public async Task<Ibge> CreateIbgeAsync(Ibge ibge)
        {
            await _context.AddAsync(ibge);
            await _context.SaveChangesAsync();

            return ibge;
        }

        public async Task<List<Ibge>> GetAllIbgeAsync()
        {
            var ibges = await _context.Ibges.ToListAsync();
            return ibges;
        }

        public async Task<Ibge> GetIdIbge(int id)
        {
            var idIbge = await _context.Ibges.FirstOrDefaultAsync(x  => x.Id == id);
            return idIbge;
        }

        public async Task<List<Ibge>> GetCityIbge(string city)
        {
            var cityIbgeList = await _context.Ibges.Where(i => i.City == city).ToListAsync();
            return cityIbgeList;
        }

        public async Task<List<Ibge>> GetStateIbge(string state)
        {
            var stateIbgeList = await _context.Ibges.Where(i => i.State == state).ToListAsync();
            return stateIbgeList;
        }
    }
}
