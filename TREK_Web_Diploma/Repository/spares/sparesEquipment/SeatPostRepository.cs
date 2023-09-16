using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Repository.spares.sparesEquipment
{
    public class SeatPostRepository : ISeatPostRepository
    {
        ApplicationDbContext _context;
        public SeatPostRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(SeatPost seatPost)
        {
            _context.Add(seatPost);
            return Save();
        }

        public bool Delete(SeatPost seatPost)
        {
            _context.Remove(seatPost);
            return Save();
        }

        public async Task<IEnumerable<SeatPost>> GetAll()
        {
            return await _context.SeatPostDB.ToListAsync();
        }

        public async Task<SeatPost> GetByIdAsync(int id)
        {
            return await _context.SeatPostDB.FirstOrDefaultAsync(i => i.SeatPostId == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(SeatPost seatPost)
        {
            _context.Update(seatPost);
            return Save();
        }
    }
}
