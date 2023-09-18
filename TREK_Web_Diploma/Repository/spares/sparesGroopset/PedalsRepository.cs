using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Repository.spares.sparesGroopset
{
    public class PedalsRepository : IPedalsRepository
    {
        ApplicationDbContext _context;
        public PedalsRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Pedals pedals)
        {
            _context.Add(pedals);
            return Save();
        }

        public bool Delete(Pedals pedals)
        {
            _context.Remove(pedals);
            return Save();
        }

        public async Task<IEnumerable<Pedals>> GetAll()
        {
            return await _context.PedalsDB.ToListAsync();
        }

        public async Task<Pedals> GetByIdAsync(int id)
        {
            return await _context.PedalsDB.FirstOrDefaultAsync(i => i.PedalsId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Pedals pedals)
        {
            _context.Update(pedals);
            return Save();
        }
    }
}
