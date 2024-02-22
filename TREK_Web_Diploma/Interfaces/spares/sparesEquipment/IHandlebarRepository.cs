using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Interfaces.spares.sparesEquipment
{
    public interface IHandlebarRepository
    {
        Task<IEnumerable<Handlebar>> GetAll();
        Task<Handlebar> GetByIdAsync(int id);
        Task<Handlebar> GetByIdAsyncNoTracking(int id);
        bool Add(Handlebar handlebar);
        bool Delete(Handlebar handlebar); 
        bool Update(Handlebar handlebar);
        bool Save();
    }
}
