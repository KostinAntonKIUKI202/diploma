using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesFrameset
{
    public interface IForkRepository
    {
        Task<IEnumerable<Fork>> GetAll();
        Task<Fork> GetByIdAsync(int id);
        Task<Fork> GetByIdAsyncNoTracking(int id);
        bool Add(Fork fork);
        bool Delete(Fork fork);
        bool Update(Fork fork);
        bool Save();
    }
}
