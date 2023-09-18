using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Repository.spares.sparesTransmition
{
    public class ShifterRepository : IShifterRepository
    {
        ApplicationDbContext _context;
        public ShifterRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Shifter shifter)
        {
            _context.Add(shifter);
            return Save();
        }

        public bool Delete(Shifter shifter)
        {
            _context.Remove(shifter);
            return Save();
        }

        public async Task<IEnumerable<Shifter>> GetAll()
        {
            return await _context.ShifterDB.ToListAsync();
        }

        public async Task<Shifter> GetByIdAsync(int id)
        {
            return await _context.ShifterDB.FirstOrDefaultAsync(i => i.ShifterId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Shifter shifter)
        {
            _context.Update(shifter);
            return Save();
        }
    }
}
