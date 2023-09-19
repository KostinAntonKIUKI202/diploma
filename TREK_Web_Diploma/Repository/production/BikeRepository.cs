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
            return await _context.BikeDB
                .Include(a => a.Equipment)
                .Include(a => a.Frameset)
                .Include(a => a.Groopset)
                .Include(a => a.Wheelset)
                .Include(a => a.Equipment.Brake)
                .Include(a => a.Equipment.Grips)
                .Include(a => a.Equipment.Handlebar)
                .Include(a => a.Equipment.Saddle)
                .Include(a => a.Equipment.SeatPost)
                .Include(a => a.Equipment.Steering)
                .Include(a => a.Equipment.Stem)
                .Include(a => a.Frameset.BikeSize)
                .Include(a => a.Frameset.Frame)
                .Include(a => a.Frameset.Fork)
                .Include(a => a.Groopset.Transmition)
                .Include(a => a.Groopset.Transmition.FrontGear)
                .Include(a => a.Groopset.Transmition.Switch)
                .Include(a => a.Groopset.Transmition.Cassette)
                .Include(a => a.Groopset.Transmition.Shifter)
                .Include(a => a.Groopset.Pedals)
                .Include(a => a.Groopset.Carriage)
                .Include(a => a.Wheelset.Hub)
                .Include(a => a.Wheelset.Rim)
                .Include(a => a.Wheelset.Tire)
                .FirstOrDefaultAsync(i => i.BikeId == id);
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
