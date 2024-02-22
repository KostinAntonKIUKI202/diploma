using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Repository.spares.sparesTransmition
{
    public class FrontGearRepository : IFrontGearRepository
    {
        ApplicationDbContext _context;
        public FrontGearRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(FrontGear frontGear)
        {
            _context.Add(frontGear);
            return Save();
        }

        public bool Delete(FrontGear frontGear)
        {
            _context.Remove(frontGear);
            return Save();
        }

        public async Task<IEnumerable<FrontGear>> GetAll()
        {
            return await _context.FrontGearDB.ToListAsync();
        }

        public async Task<FrontGear> GetByIdAsync(int id)
        {
            return await _context.FrontGearDB
                .FirstOrDefaultAsync(i => i.FrontGearId == id);
        }

        public async Task<FrontGear> GetByIdAsyncNoTracking(int id)
        {
            return await _context.FrontGearDB
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.FrontGearId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(FrontGear frontGear)
        {
            _context.Update(frontGear);
            return Save();
        }
    }
}
