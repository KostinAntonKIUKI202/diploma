using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Repository.spares.sparesEquipment
{
    public class HandlebarRepository : IHandlebarRepository
    {
        ApplicationDbContext _context;
        public HandlebarRepository(ApplicationDbContext context) 
        {  
            _context = context; 
        }
        public bool Add(Handlebar handlebar)
        {
            _context.Add(handlebar);
            return Save();
        }

        public bool Delete(Handlebar handlebar)
        {
            _context.Remove(handlebar);
            return Save();
        }

        public async Task<IEnumerable<Handlebar>> GetAll()
        {
            return await _context.HandlebarDB.ToListAsync();
        }

        public async Task<Handlebar> GetByIdAsync(int id)
        {
            return await _context.HandlebarDB.FirstOrDefaultAsync(i => i.HandlebarId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Handlebar handlebar)
        {
            _context.Update(handlebar);
            return Save();
        }
    }
}
