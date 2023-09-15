using TREK_Web_Diploma.Models.factory;

namespace TREK_Web_Diploma.Interfaces.factory
{
    public interface IJobTitleRepository
    {
        Task<IEnumerable<JobTitle>> GetAll();
        Task<JobTitle> GetByIdAsync(int id);
        Task<IEnumerable<JobTitle>> GetByJobTitleName(string jobTitleName);
        bool Add(JobTitle jobTitle);
        bool Delete(JobTitle jobTitle);
        bool Update(JobTitle jobTitle);
        bool Save();

    }
}
