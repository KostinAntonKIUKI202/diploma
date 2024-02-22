using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesFrameset
{
    public interface IBikeSizeRepository
    {
        Task<IEnumerable<BikeSize>> GetAll();
        Task<BikeSize> GetByIdAsync(int id);
        Task<BikeSize> GetByIdAsyncNoTracking(int id);
        bool Add(BikeSize bikeSize);
        bool Delete(BikeSize bikeSize);
        bool Update(BikeSize bikeSize);
        bool Save();
    }
}
