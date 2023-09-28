using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class BrakeController : Controller
    {
        private readonly IBrakeRepository _brakeRepository;
        public BrakeController(IBrakeRepository brakeRepository)
        {
            _brakeRepository = brakeRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Brake> brakes = await _brakeRepository.GetAll();
            return View(brakes);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
