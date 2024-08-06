using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Repository.production
{
    public class FramesetRepository : IFramesetRepository
    {
        ApplicationDbContext _context;
        public FramesetRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Frameset frameset)
        {
            _context.Add(frameset);
            return Save();
        }

        public bool Delete(Frameset frameset)
        {
            _context.Remove(frameset);
            return Save();
        }

        public async Task<IEnumerable<Frameset>> GetAll()
        {
            return await _context.FramesetDB
                .Include(c => c.Frame)
                .Include(c => c.Fork)
                .ToListAsync();
        }

        public async Task<Frameset> GetByIdAsync(int id)
        {
            return await _context.FramesetDB
                .Include(a => a.Fork)
                .Include(a => a.Frame)
                .Include(a => a.BikeSize)
                .FirstOrDefaultAsync(i => i.FramesetId == id);
        }

        public async Task<Frameset> GetByIdAsyncNoTracking(int id)
        {
            return await _context.FramesetDB
                .Include(a => a.Fork)
                .Include(a => a.Frame)
                .Include(a => a.BikeSize)
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.FramesetId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Frameset frameset)
        {
            _context.Update(frameset);
            return Save();
        }
    }
}
