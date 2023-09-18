using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Repository.spares.sparesTransmition
{
    public class SwitchRepository : ISwitchRepository
    {
        ApplicationDbContext _context;
        public SwitchRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Switch @switch)
        {
            _context.Add(@switch);
            return Save();
        }

        public bool Delete(Switch @switch)
        {
            _context.Remove(@switch);
            return Save();
        }

        public async Task<IEnumerable<Switch>> GetAll()
        {
            return await _context.SwitchDB.ToListAsync();
        }

        public async Task<Switch> GetByIdAsync(int id)
        {
            return await _context.SwitchDB.FirstOrDefaultAsync(i => i.SwitchId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Switch @switch)
        {
            _context.Update(@switch);
            return Save();
        }
    }
}
