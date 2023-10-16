using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.spares.sparesTransmition
{
    public class FrontGearController : Controller
    {
        private readonly IFrontGearRepository _frontGearRepository;
        public FrontGearController(IFrontGearRepository frontGearRepository)
        {
            _frontGearRepository = frontGearRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<FrontGear> frontGears = await _frontGearRepository.GetAll();
            return View(frontGears);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(FrontGear frontGear)
        {
            if (!ModelState.IsValid)
            {
                return View(frontGear);
            }
            _frontGearRepository.Add(frontGear);
            return RedirectToAction("Create");
        }
    }
}
