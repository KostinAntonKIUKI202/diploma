using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Repository.production
{
    public class BikeRepository : IBikeRepository
    {
        private readonly ApplicationDbContext _context;
        public BikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Bike bike)
        {
            _context.Add(bike);
            return Save();
        }

        public bool Delete(Bike bike)
        {
            _context.Remove(bike);
            return Save();
        }

        public async Task<IEnumerable<Bike>> GetAll()
        {
            return await _context.BikeDB.ToListAsync();
        }

        public async Task<IEnumerable<Bike>> GetByBikeName(string bikeName)
        {
            return await _context.BikeDB.Where(c => c.BikeName.Contains(bikeName)).ToListAsync();
        }

        public Task<IEnumerable<Bike>> GetByBikePrice(int bikePrice)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Bike>> GetByEqupmentBrake(string brakeName)
        {
            return await _context.BikeDB.Where(c => c.Equipment.Brake.BrakeName.Contains(brakeName)).ToListAsync();
        }

        public async Task<IEnumerable<Bike>> GetByGroopsetCassette(string cassette)
        {
            return await _context.BikeDB.Where(c => c.Groopset.Transmition.Cassette.CassetteName.Contains(cassette)).ToListAsync();
        }

        public async Task<Bike> GetByIdAsync(int id)
        {
            return await _context.BikeDB.FirstOrDefaultAsync(i => i.BikeId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Bike bike)
        {
            _context.Update(bike);
            return Save();
        }
    }
}
