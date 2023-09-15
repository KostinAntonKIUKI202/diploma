using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Interfaces.spares.sparesEquipment
{
    public interface ISteeringRepository
    {
        Task<IEnumerable<Steering>> GetAll();
        Task<Steering> GetByIdAsync(int id);
        bool Add(Steering steering);
        bool Delete(Steering steering); 
        bool Update(Steering steering);
        bool Save();
    }
}
