using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.factory;
using TREK_Web_Diploma.Models.factory;

namespace TREK_Web_Diploma.Repository.factory
{
    public class JobTitleRepository : IJobTitleRepository
    {
        private readonly ApplicationDbContext _context;
        public JobTitleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(JobTitle jobTitle)
        {
            _context.Add(jobTitle);
            return Save();
        }

        public bool Delete(JobTitle jobTitle)
        {
            _context.Remove(jobTitle);
            return Save();
        }

        public async Task<IEnumerable<JobTitle>> GetAll()
        {
            return await _context.JobTitleDB.ToListAsync();
        }

        public async Task<JobTitle> GetByIdAsync(int id)
        {
            return await _context.JobTitleDB.FirstOrDefaultAsync(i => i.JobTitleId == id);
        }

        public async Task<IEnumerable<JobTitle>> GetByJobTitleName(string jobTitleName)
        {
            return await _context.JobTitleDB.Where(c => c.JobTitleName.Contains(jobTitleName)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(JobTitle jobTitle)
        {
            _context.Update(jobTitle);
            return Save();
        }
    }
}
