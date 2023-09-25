using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Controllers.sparesGroopset
{
    public class CarriageController : Controller
    {
        private readonly ICarriageRepository _carriageRepository;
        public CarriageController(ICarriageRepository carriageRepository)
        {
            _carriageRepository = carriageRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Carriage> carriages = await _carriageRepository.GetAll();
            return View(carriages);
        }
        public IActionResult Create() 
        {
            return View();
        }
    }
}
