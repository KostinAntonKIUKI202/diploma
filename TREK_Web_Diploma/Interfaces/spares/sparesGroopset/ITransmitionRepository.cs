using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesGroopset
{
    public interface ITransmitionRepository
    {
        Task<IEnumerable<Transmition>> GetAll();
        Task<Transmition> GetByIdAsync(int id);
        Task<Transmition> GetByIdAsyncNoTracking(int id);
        bool Add(Transmition transmition); 
        bool Delete(Transmition transmition); 
        bool Update(Transmition transmition);
        bool Save();
    }
}
