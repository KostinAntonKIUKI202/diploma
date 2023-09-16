using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Repository.spares.sparesEquipment
{
    public class GripsRepository : IGripsRepository
    {
        ApplicationDbContext _context;
        public GripsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Grips grips)
        {
            _context.Add(grips);
            return Save();
        }

        public bool Delete(Grips grips)
        {
            _context.Remove(grips);
            return Save();
        }

        public async Task<IEnumerable<Grips>> GetAll()
        {
            return await _context.GripsDB.ToListAsync();
        }

        public async Task<Grips> GetByIdAsync(int id)
        {
            return await _context.GripsDB.FirstOrDefaultAsync(i => i.GripsId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Grips grips)
        {
            _context.Update(grips);
            return Save();
        }
    }
}
