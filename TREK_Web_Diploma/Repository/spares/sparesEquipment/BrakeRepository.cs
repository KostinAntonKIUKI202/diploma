using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Repository.spares.sparesEquipment
{
    public class BrakeRepository : IBrakeRepository
    {
        ApplicationDbContext _context;
        public BrakeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Brake brake)
        {
            _context.Add(brake);
            return Save();
        }

        public bool Delete(Brake brake)
        {
            _context.Remove(brake);
            return Save();
        }

        public async Task<IEnumerable<Brake>> GetAll()
        {
            return await _context.BrakeDB.ToListAsync();
        }

        public async Task<Brake> GetByIdAsync(int id)
        {
            return await _context.BrakeDB.FirstOrDefaultAsync(i => i.BrakeId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Brake brake)
        {
            _context.Update(brake);
            return Save();
        }
    }
}
