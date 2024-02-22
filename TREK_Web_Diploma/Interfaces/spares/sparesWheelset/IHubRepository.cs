using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesWheelset
{
    public interface IHubRepository
    {
        Task<IEnumerable<Hub>> GetAll();
        Task<Hub> GetByIdAsync(int id);
        Task<Hub> GetByIdAsyncNoTracking(int id);
        bool Add(Hub hub);
        bool Delete(Hub hub);
        bool Update(Hub hub);
        bool Save();
    }
}
