using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Repository.spares.sparesFrameset
{
    public class BikeSizeRepository : IBikeSizeRepository
    {
        ApplicationDbContext _context;
        public BikeSizeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(BikeSize bikeSize)
        {
            _context.Add(bikeSize);
            return Save();
        }

        public bool Delete(BikeSize bikeSize)
        {
            _context.Remove(bikeSize);
            return Save();
        }

        public async Task<IEnumerable<BikeSize>> GetAll()
        {
            return await _context.BikeSizeDB.ToListAsync();
        }

        public async Task<BikeSize> GetByIdAsync(int id)
        {
            return await _context.BikeSizeDB.FirstOrDefaultAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(BikeSize bikeSize)
        {
            _context.Update(bikeSize);
            return Save();
        }
    }
}
