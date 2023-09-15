using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesGroopset
{
    public interface ICarriageRepository
    {
        Task<IEnumerable<Carriage>> GetAll();
        Task<Carriage> GetByIdAsync(int id);
        bool Add(Carriage carriage);
        bool Delete(Carriage carriage); 
        bool Update(Carriage carriage);
        bool Save();
    }
}
