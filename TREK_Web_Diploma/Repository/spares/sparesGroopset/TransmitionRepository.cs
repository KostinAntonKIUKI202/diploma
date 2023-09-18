using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Repository.spares.sparesGroopset
{
    public class TransmitionRepository : ITransmitionRepository
    {
        ApplicationDbContext _context;
        public TransmitionRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Transmition transmition)
        {
            _context.Add(transmition);
            return Save();
        }

        public bool Delete(Transmition transmition)
        {
            _context.Remove(transmition);
            return Save();
        }

        public async Task<IEnumerable<Transmition>> GetAll()
        {
            return await _context.TransmitionDB.ToListAsync();
        }

        public async Task<Transmition> GetByIdAsync(int id)
        {
            return await _context.TransmitionDB.FirstOrDefaultAsync(i => i.TransmitionId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Transmition transmition)
        {
            _context.Update(transmition);
            return Save();
        }
    }
}
