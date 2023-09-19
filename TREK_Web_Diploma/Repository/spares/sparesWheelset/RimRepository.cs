using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Repository.spares.sparesWheelset
{
    public class RimRepository : IRimRepository
    {
        ApplicationDbContext _context;
        public RimRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Rim rim)
        {
            _context.Add(rim);
            return Save();
        }

        public bool Delete(Rim rim)
        {
            _context.Remove(rim);
            return Save();
        }

        public async Task<IEnumerable<Rim>> GetAll()
        {
            return await _context.RimDB.ToListAsync();
        }

        public async Task<Rim> GetByIdAsync(int id)
        {
            return await _context.RimDB.FirstOrDefaultAsync(i => i.RimId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Rim rim)
        {
            _context.Update(rim);
            return Save();
        }
    }
}
