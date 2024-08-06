using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.ViewModels;

namespace TREK_Web_Diploma.Interfaces.production
{
    public interface IBikeRepository
    {
        Task<IEnumerable<Bike>> GetAllFull();
        Task<IEnumerable<Bike>> GetAll();
        Task<Bike> GetByIdAsync(int id);
        Task<Bike> GetByIdAsyncNoTracking(int id);
        Task<IEnumerable<Bike>> GetByBikeName(string bikeName);
        Task<IEnumerable<Bike>> GetByBikePrice(int minBikePrice, int maxBikePrice);
        Task<IEnumerable<Bike>> GetByEqupmentBrake(string brakeName);
        Task<IEnumerable<Bike>> GetByGroopsetCassette(string cassette);
        bool Add(Bike bike);
        bool Delete(Bike bike);
        bool Update(Bike bike);
        bool Save();
    }
}
