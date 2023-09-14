using TREK_Web_Diploma.Models.factory;

namespace TREK_Web_Diploma.Interfaces.factory
{
    public interface IFactoryRepository
    {
        Task<IEnumerable<Factory>> GetAll();
        Task<Factory> GetByIdAsync(int id);
        Task<Factory> GetByCity(string city);
        bool Add(Factory factory);
        bool Delete(Factory factory);
        bool Update(Factory factory);
        bool Save();
    }
}
