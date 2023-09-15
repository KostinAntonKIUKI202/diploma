using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Interfaces.production
{
    public interface IGroopsetRepository
    {
        Task<IEnumerable<Groopset>> GetAll();
        Task<Groopset> GetByIdAsync(int id);
        bool Add(Groopset groopset);
        bool Delete(Groopset groopset);
        bool Update(Groopset groopset);
        bool Save();
    }
}
