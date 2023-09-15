using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Interfaces.spares.sparesTransmition
{
    public interface ICassetteRepository
    {
        Task<IEnumerable<Cassette>> GetAll();
        Task<Cassette> GetByIdAsync(int id);
        bool Add(Cassette cassette);
        bool Delete(Cassette cassette);
        bool Update(Cassette cassette);
        bool Save();
    }
}
