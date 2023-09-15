using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Interfaces.spares.sparesEquipment
{
    public interface IStemRepository
    {
        Task<IEnumerable<Stem>> GetAll();
        Task<Stem> GetByIdAsync(int id);
        bool Add(Stem stem);
        bool Delete(Stem stem);
        bool Update(Stem stem);
        bool Save();
    }
}
