using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Interfaces.spares.sparesFrameset
{
    public interface IFrameRepository
    {
        Task<IEnumerable<Frame>> GetAll();
        Task<Frame> GetByIdAsync(int id);
        Task<Frame> GetByIdAsyncNoTracking(int id);
        bool Add(Frame frame);
        bool Delete(Frame frame); 
        bool Update(Frame frame);
        bool Save();
    }
}
