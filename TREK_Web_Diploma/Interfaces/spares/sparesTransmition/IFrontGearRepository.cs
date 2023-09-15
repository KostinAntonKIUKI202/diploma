using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Interfaces.spares.sparesTransmition
{
    public interface IFrontGearRepository
    {
        Task<IEnumerable<FrontGear>> GetAll();
        Task<FrontGear> GetByIdAsync(int id);
        bool Add(FrontGear frontGear); 
        bool Delete(FrontGear frontGear); 
        bool Update(FrontGear frontGear);
        bool Save();
    }
}
