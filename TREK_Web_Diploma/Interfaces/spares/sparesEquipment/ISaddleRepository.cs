using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Interfaces.spares.sparesEquipment
{
    public interface ISaddleRepository
    {
        Task<IEnumerable<Saddle>> GetAll();
        Task<Saddle> GetByIdAsync(int id);
        bool Add(Saddle saddle); 
        bool Delete(Saddle saddle);
        bool Update(Saddle saddle);
        bool Save();
    }
}
