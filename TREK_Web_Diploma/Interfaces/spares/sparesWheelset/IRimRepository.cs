using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesWheelset
{
    public interface IRimRepository
    {
        Task<IEnumerable<Rim>> GetAll();
        Task<Rim> GetByIdAsync(int id);
        Task<Rim> GetByIdAsyncNoTracking(int id);
        bool Add(Rim rim);
        bool Delete(Rim rim);
        bool Update(Rim rim);
        bool Save();
    }
}
