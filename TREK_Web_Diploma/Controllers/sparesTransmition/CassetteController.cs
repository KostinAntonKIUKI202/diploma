using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.sparesTransmition
{
    public class CassetteController : Controller
    {
        private readonly ICassetteRepository _cassetteRepository;
        public CassetteController(ICassetteRepository cassetteRepository)
        {
            _cassetteRepository = cassetteRepository;
        }
        public async Task<IActionResult> Index()
        { 
            IEnumerable<Cassette> cassettes = await _cassetteRepository.GetAll();
            return View(cassettes);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
