using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class GripsController : Controller
    {
        private readonly IGripsRepository _gripsRepository;
        public GripsController(IGripsRepository gripsRepository)
        {
            _gripsRepository = gripsRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Grips> grips = await _gripsRepository.GetAll();
            return View(grips);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
