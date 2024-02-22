using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Interfaces.production
{
    public interface IWheelsetRepository
    {
        Task<IEnumerable<Wheelset>> GetAll();
        Task<Wheelset> GetByIdAsync(int id);
        Task<Wheelset> GetByIdAsyncNoTracking(int id);
        bool Add(Wheelset wheelset);
        bool Delete(Wheelset wheelset);
        bool Update(Wheelset wheelset);
        bool Save();

    }
}
