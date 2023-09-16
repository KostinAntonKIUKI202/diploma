using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Repository.production
{
    public class EquipmentRepository : IEquipmentRepository
    {
        ApplicationDbContext _context;
        public EquipmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Equipment equipment)
        {
            _context.Add(equipment);
            return Save();
        }

        public bool Delete(Equipment equipment)
        {
            _context.Remove(equipment);
            return Save();
        }

        public async Task<IEnumerable<Equipment>> GetAll()
        {
            return await _context.EquipmentDB.ToListAsync();
        }

        public async Task<Equipment> GetByIdAsync(int id)
        {
            return await _context.EquipmentDB.FirstOrDefaultAsync(i => i.EquipmentId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Equipment equipment)
        {
            _context.Update(equipment);
            return Save();
        }
    }
}
