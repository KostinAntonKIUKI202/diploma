using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Repository.spares.sparesGroopset
{
    public class CarriageRepository : ICarriageRepository
    {
        ApplicationDbContext _context;
        public CarriageRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Carriage carriage)
        {
            _context.Add(carriage);
            return Save();
        }

        public bool Delete(Carriage carriage)
        {
            _context.Remove(carriage);
            return Save();
        }

        public async Task<IEnumerable<Carriage>> GetAll()
        {
            return await _context.CarriageDB.ToListAsync();
        }

        public async Task<Carriage> GetByIdAsync(int id)
        {
            return await _context.CarriageDB.FirstOrDefaultAsync(i => i.CarriageId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Carriage carriage)
        {
            _context.Update(carriage);
            return Save();
        }
    }
}
