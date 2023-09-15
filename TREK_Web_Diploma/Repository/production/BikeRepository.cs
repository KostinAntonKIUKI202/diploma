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
            throw new NotImplementedException();
        }

        public bool Delete(Bike bike)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bike>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bike>> GetByBikeName(string bikeName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bike>> GetByBikePrice(int bikePrice)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bike>> GetByEqupmentBrake(string brakeName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Bike>> GetByGroopsetCassette(string cassette)
        {
            throw new NotImplementedException();
        }

        public Task<Bike> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Bike bike)
        {
            throw new NotImplementedException();
        }
    }
}
