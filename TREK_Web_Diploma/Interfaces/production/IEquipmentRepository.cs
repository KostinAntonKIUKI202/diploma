using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Interfaces.production
{
    public interface IEquipmentRepository
    {
        Task<IEnumerable<Equipment>> GetAll();
        Task<Equipment> GetByIdAsync(int id);
        bool Add(Equipment equipment);
        bool Delete(Equipment equipment);
        bool Update(Equipment equipment);
        bool Save();
    }
}
