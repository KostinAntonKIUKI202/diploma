using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Repository.spares.sparesEquipment
{
    public class StemRepository : IStemRepository
    {
        ApplicationDbContext _context;
        public StemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Stem stem)
        {
            _context.Add(stem);
            return Save();
        }

        public bool Delete(Stem stem)
        {
            _context.Remove(stem);
            return Save();
        }

        public async Task<IEnumerable<Stem>> GetAll()
        {
            return await _context.StemDB.ToListAsync();
        }

        public async Task<Stem> GetByIdAsync(int id)
        {
            return await _context.StemDB
                .FirstOrDefaultAsync(i => i.StemId == id);
        }

        public async Task<Stem> GetByIdAsyncNoTracking(int id)
        {
            return await _context.StemDB
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.StemId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Stem stem)
        {
            _context.Update(stem);
            return Save();
        }
    }
}
