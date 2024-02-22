using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesGroopset
{
    public interface IPedalsRepository
    {
        Task<IEnumerable<Pedals>> GetAll();
        Task<Pedals> GetByIdAsync(int id);
        Task<Pedals> GetByIdAsyncNoTracking(int id);
        bool Add(Pedals pedals);
        bool Delete(Pedals pedals); 
        bool Update(Pedals pedals);
        bool Save();
    }
}
