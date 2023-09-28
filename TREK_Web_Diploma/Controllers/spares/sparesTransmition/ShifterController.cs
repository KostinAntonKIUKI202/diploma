using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.spares.sparesTransmition
{
    public class ShifterController : Controller
    {
        private readonly IShifterRepository _shifterRepository;
        public ShifterController(IShifterRepository shifterRepository)
        {
            _shifterRepository = shifterRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Shifter> shifters = await _shifterRepository.GetAll();
            return View(shifters);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
