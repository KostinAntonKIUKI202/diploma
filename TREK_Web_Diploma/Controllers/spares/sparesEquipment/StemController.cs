using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class StemController : Controller
    {
        private readonly IStemRepository _stemRepository;
        public StemController(IStemRepository stemRepository)
        {
            _stemRepository = stemRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Stem> stems = await _stemRepository.GetAll();
            return View(stems);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
