using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Repository.spares.sparesEquipment
{
    public class SaddleRepository : ISaddleRepository
    {
        ApplicationDbContext _context;
        public SaddleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Saddle saddle)
        {
            _context.Add(saddle);
            return Save();
        }

        public bool Delete(Saddle saddle)
        {
            _context.Remove(saddle);
            return Save();
        }

        public async Task<IEnumerable<Saddle>> GetAll()
        {
            return await _context.SaddleDB.ToListAsync();
        }

        public async Task<Saddle> GetByIdAsync(int id)
        {
            return await _context.SaddleDB.FirstOrDefaultAsync(i => i.SaddleId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Saddle saddle)
        {
            _context.Update(saddle);
            return Save();
        }
    }
}
