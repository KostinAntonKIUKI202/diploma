using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Interfaces.production
{
    public interface IFramesetRepository
    {
        Task<IEnumerable<Frameset>> GetAll();
        Task<Frameset> GetByIdAsync(int id);
        Task<Frameset> GetByIdAsyncNoTracking(int id);
        bool Add(Frameset frameset);
        bool Delete(Frameset frameset);
        bool Update(Frameset frameset);
        bool Save();
    }
}
