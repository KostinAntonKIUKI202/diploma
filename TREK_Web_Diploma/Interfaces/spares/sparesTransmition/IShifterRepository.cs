using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Interfaces.spares.sparesTransmition
{
    public interface IShifterRepository
    {
        Task<IEnumerable<Shifter>> GetAll();
        Task<Shifter> GetByIdAsync(int id);
        Task<Shifter> GetByIdAsyncNoTracking(int id);
        bool Add(Shifter shifter); 
        bool Delete(Shifter shifter);
        bool Update(Shifter shifter);
        bool Save();
    }
}
