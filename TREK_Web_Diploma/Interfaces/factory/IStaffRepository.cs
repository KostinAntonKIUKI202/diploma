using TREK_Web_Diploma.Models.factory;

namespace TREK_Web_Diploma.Interfaces.factory
{
    public interface IStaffRepository
    {
        Task<IEnumerable<Staff>> GetAll();
        Task<Staff> GetByIdAsync(int id);
        Task<Staff> GetByFirstName(string firstName);
        Task<Staff> GetBySecondName(string secondName);
        Task<Staff> GetByFactoryCity(string factoryCity);
        bool Add(Staff staff);
        bool Delete(Staff staff);
        bool Update(Staff staff);
        bool Save();
    }
}
