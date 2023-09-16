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
            return await _context.FramesetDB.ToListAsync();
        }

        public Task<Frameset> GetByIdAsync(int id)
        {
            return _context.FramesetDB.FirstOrDefaultAsync(i => i.FramesetId == id);
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
