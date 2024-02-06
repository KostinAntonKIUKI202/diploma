using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Controllers.spares.sparesGroopset
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

        [HttpPost]
        public async Task<IActionResult> Create(Carriage carriage)
        {
            if (!ModelState.IsValid)
            {
                return View(carriage);
            }
            _carriageRepository.Add(carriage);
            return RedirectToAction("Create");
        }
    }
}
