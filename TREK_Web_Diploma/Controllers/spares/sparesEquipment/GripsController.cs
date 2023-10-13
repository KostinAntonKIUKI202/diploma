using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
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

        [HttpPost]
        public async Task<IActionResult> Create(Grips grips)
        {
            if (!ModelState.IsValid)
            {
                return View(grips);
            }
            _gripsRepository.Add(grips);
            return RedirectToAction("Create");
        }
    }
}
