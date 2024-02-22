using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Repository.spares.sparesWheelset
{
    public class HubRepository : IHubRepository
    {
        ApplicationDbContext _context;
        public HubRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Hub hub)
        {
            _context.Add(hub);
            return Save();
        }

        public bool Delete(Hub hub)
        {
            _context.Remove(hub);
            return Save();
        }

        public async Task<IEnumerable<Hub>> GetAll()
        {
            return await _context.HubDB.ToListAsync();
        }

        public async Task<Hub> GetByIdAsync(int id)
        {
            return await _context.HubDB
                .FirstOrDefaultAsync(i => i.HubId == id);
        }

        public async Task<Hub> GetByIdAsyncNoTracking(int id)
        {
            return await _context.HubDB
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.HubId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Hub hub)
        {
            _context.Update(hub);
            return Save();
        }
    }
}
