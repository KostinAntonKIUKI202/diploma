using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Interfaces.spares.sparesEquipment
{
    public interface IGripsRepository
    {
        Task<IEnumerable<Grips>> GetAll();
        Task<Grips> GetByIdAsync(int id);
        bool Add(Grips grips);
        bool Delete(Grips grips);
        bool Update(Grips grips);
        bool Save();
    }
}
