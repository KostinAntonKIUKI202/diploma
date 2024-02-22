using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Repository.spares.sparesFrameset
{
    public class FrameRepository : IFrameRepository
    {
        ApplicationDbContext _context;
        public FrameRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Frame frame)
        {
            _context.Add(frame);
            return Save();
        }

        public bool Delete(Frame frame)
        {
            _context.Remove(frame);
            return Save();
        }

        public async Task<IEnumerable<Frame>> GetAll()
        {
            return await _context.FrameDB.ToListAsync();
        }

        public async Task<Frame> GetByIdAsync(int id)
        {
            return await _context.FrameDB
                .FirstOrDefaultAsync();
        }

        public async Task<Frame> GetByIdAsyncNoTracking(int id)
        {
            return await _context.FrameDB
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Frame frame)
        {
            _context.Update(frame);
            return Save();
        }
    }
}
