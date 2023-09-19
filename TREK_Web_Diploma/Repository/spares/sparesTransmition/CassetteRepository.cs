using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Repository.spares.sparesTransmition
{
    public class CassetteRepository : ICassetteRepository
    {
        ApplicationDbContext _context;
        public CassetteRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Cassette cassette)
        {
            _context.Add(cassette);
            return Save();
        }

        public bool Delete(Cassette cassette)
        {
            _context.Remove(cassette);
            return Save();
        }

        public async Task<IEnumerable<Cassette>> GetAll()
        {
            return await _context.CassetteDB.ToListAsync();
        }

        public async Task<Cassette> GetByIdAsync(int id)
        {
            return await _context.CassetteDB.FirstOrDefaultAsync(i => i.CassetteId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Cassette cassette)
        {
            _context.Update(cassette);
            return Save();
        }
    }
}
