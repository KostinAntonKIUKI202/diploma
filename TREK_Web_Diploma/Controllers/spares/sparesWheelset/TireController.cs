using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Controllers.spares.sparesWheelset
{
    public class TireController : Controller
    {
        private readonly ITireRepository _tireRepository;
        public TireController(ITireRepository tireRepository)
        {
            _tireRepository = tireRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Tire> tires = await _tireRepository.GetAll();
            return View(tires);
        }
        public IActionResult Create()
        {
            return View();            
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tire tire)
        {
            if (!ModelState.IsValid)
            {
                return View(tire);
            }
            _tireRepository.Add(tire);
            return RedirectToAction("Create");
        }
    }
}
