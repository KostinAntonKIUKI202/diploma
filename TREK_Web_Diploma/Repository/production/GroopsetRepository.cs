using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Repository.production
{
    public class GroopsetRepository : IGroopsetRepository
    {
        ApplicationDbContext _context;
        public GroopsetRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Groopset groopset)
        {
            _context.Add(groopset);
            return Save();
        }

        public bool Delete(Groopset groopset)
        {
            _context.Remove(groopset);
            return Save();
        }

        public async Task<IEnumerable<Groopset>> GetAll()
        {
            return await _context.GroopsetDB.ToListAsync();
        }

        public async Task<Groopset> GetByIdAsync(int id)
        {
            return await _context.GroopsetDB.FirstOrDefaultAsync(i => i.GroopsetId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Groopset groopset)
        {
            _context.Update(groopset);
            return Save();
        }
    }
}
