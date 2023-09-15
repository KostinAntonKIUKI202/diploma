using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesWheelset
{
    public interface IHubRepository
    {
        Task<IEnumerable<Models.spares.sparesWheelset.Hub>> GetAll();
        Task<Models.spares.sparesWheelset.Hub> GetByIdAsync(int id);
        bool Add(Models.spares.sparesWheelset.Hub hub);
        bool Delete(Models.spares.sparesWheelset.Hub hub);
        bool Update(Models.spares.sparesWheelset.Hub hub);
        bool Save();
    }
}
