using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Repository.spares.sparesWheelset
{
    public class TireRepository : ITireRepository
    {
        ApplicationDbContext _context;
        public TireRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Tire tire)
        {
            _context.Add(tire);
            return Save();
        }

        public bool Delete(Tire tire)
        {
            _context.Remove(tire);
            return Save();
        }

        public async Task<IEnumerable<Tire>> GetAll()
        {
            return await _context.TireDB.ToListAsync();
        }

        public async Task<Tire> GetByIdAsync(int id)
        {
            return await _context.TireDB
                .FirstOrDefaultAsync(i => i.TireId == id);
        }

        public async Task<Tire> GetByIdAsyncNoTracking(int id)
        {
            return await _context.TireDB
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.TireId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Tire tire)
        {
            _context.Update(tire);
            return Save();
        }
    }
}
