using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Repository.spares.sparesEquipment
{
    public class SteeringRepository : ISteeringRepository
    {
        ApplicationDbContext _context;
        public SteeringRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Steering steering)
        {
            _context.Add(steering);
            return Save();
        }

        public bool Delete(Steering steering)
        {
            _context.Remove(steering);
            return Save();
        }

        public async Task<IEnumerable<Steering>> GetAll()
        {
            return await _context.SteeringDB.ToListAsync();
        }

        public async Task<Steering> GetByIdAsync(int id)
        {
            return await _context.SteeringDB
                .FirstOrDefaultAsync(i => i.SteeringId == id);
        }

        public async Task<Steering> GetByIdAsyncNoTracking(int id)
        {
            return await _context.SteeringDB
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.SteeringId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Steering steering)
        {
            _context.Update(steering);
            return Save();
        }
    }
}
