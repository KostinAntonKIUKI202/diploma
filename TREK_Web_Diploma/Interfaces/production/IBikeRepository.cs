using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Interfaces.production
{
    public interface IBikeRepository
    {
        Task<IEnumerable<Bike>> GetAll();
        Task<Bike> GetByIdAsync(int id);
        Task<Bike> GetByBikeName(string bikeName);
        Task<Bike> GetByBikePrice(int bikePrice);
        Task<Bike> GetByEqupmentBrake(string brakeName);
        Task<Bike> GetByGroopsetCassette(string cassette);
        bool Add(Bike bike);
        bool Delete(Bike bike);
        bool Update(Bike bike);
        bool Save();
    }
}
