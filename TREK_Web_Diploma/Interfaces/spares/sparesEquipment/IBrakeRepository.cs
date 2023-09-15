using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Interfaces.spares.sparesEquipment
{
    public interface IBrakeRepository
    {
        Task<IEnumerable<Brake>> GetAll();
        Task<Brake> GetByIdAsync(int id);
        bool Add(Brake brake);
        bool Delete(Brake brake);
        bool Update(Brake brake);
        bool Save();
    }
}
