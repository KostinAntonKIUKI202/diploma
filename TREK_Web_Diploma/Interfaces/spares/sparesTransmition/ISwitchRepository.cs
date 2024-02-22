using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Interfaces.spares.sparesTransmition
{
    public interface ISwitchRepository
    {
        Task<IEnumerable<Switch>> GetAll();
        Task<Switch> GetByIdAsync(int id);
        Task<Switch> GetByIdAsyncNoTracking(int id);
        bool Add(Switch @switch); 
        bool Delete(Switch @switch); 
        bool Update(Switch @switch);
        bool Save();
    }
}
