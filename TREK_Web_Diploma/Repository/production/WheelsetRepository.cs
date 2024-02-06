using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Repository.production
{
    public class WheelsetRepository : IWheelsetRepository
    {
        ApplicationDbContext _context;
        public WheelsetRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Wheelset wheelset)
        {
            _context.Add(wheelset);
            return Save();
        }

        public bool Delete(Wheelset wheelset)
        {
            _context.Remove(wheelset);
            return Save();
        }

        public async Task<IEnumerable<Wheelset>> GetAll()
        {
            return await _context.WheelsetDB
                .Include(c => c.Tire)
                .Include(c => c.Rim)
                .Include(c => c.Hub)
                .ToListAsync();
        }

        public async Task<Wheelset> GetByIdAsync(int id)
        {
            return await _context.WheelsetDB.FirstOrDefaultAsync(i => i.WheelsetId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Wheelset wheelset)
        {
            _context.Update(wheelset);
            return Save();
        }
    }
}
