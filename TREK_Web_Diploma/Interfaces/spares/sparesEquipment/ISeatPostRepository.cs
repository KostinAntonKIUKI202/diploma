using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Interfaces.spares.sparesEquipment
{
    public interface ISeatPostRepository
    {
        Task<IEnumerable<SeatPost>> GetAll();
        Task<SeatPost> GetByIdAsync(int id);
        Task<SeatPost> GetByIdAsyncNoTracking(int id);
        bool Add(SeatPost seatPost);
        bool Delete(SeatPost seatPost); 
        bool Update(SeatPost seatPost);
        bool Save();
    }
}
