using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesWheelset
{
    public interface ITireRepository
    {
        Task<IEnumerable<Tire>> GetAll();
        Task<Tire> GetByIdAsync(int id);
        Task<Tire> GetByIdAsyncNoTracking(int id);
        bool Add(Tire tire);
        bool Delete(Tire tire);
        bool Update(Tire tire);
        bool Save();
    }
}
