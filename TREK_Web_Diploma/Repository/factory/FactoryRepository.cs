using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.factory;
using TREK_Web_Diploma.Models.factory;

namespace TREK_Web_Diploma.Repository.factory
{
    public class FactoryRepository : IFactoryRepository
    {
        private readonly ApplicationDbContext _context;
        public FactoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Factory factory)
        {
            _context.Add(factory);
            return Save();
        }

        public bool Delete(Factory factory)
        {
            _context.Remove(factory);
            return Save();
        }

        public async Task<IEnumerable<Factory>> GetAll()
        {
            return await _context.FactoryDB.ToListAsync();
        }

        public async Task<IEnumerable<Factory>> GetByCity(string city)
        {
            return await _context.FactoryDB.Where(c => c.City.Contains(city)).ToListAsync();
        }

        public async Task<Factory> GetByIdAsync(int id)
        {
            return await _context.FactoryDB.FirstOrDefaultAsync(i => i.FactoryId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Factory factory)
        {
            _context.Update(factory);
            return Save();
        }
    }
}
