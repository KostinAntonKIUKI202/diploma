using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.factory;
using TREK_Web_Diploma.Models.factory;

namespace TREK_Web_Diploma.Repository.factory
{
    public class StaffRepository : IStaffRepository
    {
        private readonly ApplicationDbContext _context;
        public StaffRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Staff staff)
        {
            _context.Add(staff);
            return Save();
        }

        public bool Delete(Staff staff)
        {
            _context.Remove(staff);
            return Save();
        }

        public async Task<IEnumerable<Staff>> GetAll()
        {
            return await _context.StaffDB.ToListAsync();
        }

        public async Task<IEnumerable<Staff>> GetByFactoryCity(string factoryCity)
        {
            return await _context.StaffDB.Where(c => c.Factory.City.Contains(factoryCity)).ToListAsync();
        }

        public async Task<IEnumerable<Staff>> GetByFirstName(string firstName)
        {
            return await _context.StaffDB.Where(c => c.FirstName.Contains(firstName)).ToListAsync();
        }

        public async Task<Staff> GetByIdAsync(int id)
        {
            return await _context.StaffDB.FirstOrDefaultAsync(i => i.StaffId == id);
        }

        public async Task<IEnumerable<Staff>> GetBySecondName(string secondName)
        {
            return await _context.StaffDB.Where(c => c.SecondName.Contains(secondName)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Staff staff)
        {
            _context.Update(staff);
            return Save();
        }
    }
}
