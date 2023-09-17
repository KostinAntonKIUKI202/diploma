using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Repository.spares.sparesFrameset
{
    public class ForkRepository : IForkRepository
    {
        ApplicationDbContext _context;
        public ForkRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Fork fork)
        {
            _context.Add(fork);
            return Save();
        }

        public bool Delete(Fork fork)
        {
            _context.Remove(fork);
            return Save();
        }

        public async Task<IEnumerable<Fork>> GetAll()
        {
            return await _context.ForkDB.ToListAsync();
        }

        public async Task<Fork> GetByIdAsync(int id)
        {
            return await _context.ForkDB.FirstOrDefaultAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Fork fork)
        {
            _context.Update(fork);
            return Save();
        }
    }
}
