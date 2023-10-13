using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
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

        [HttpPost]
        public async Task<IActionResult> Create(Stem stem)
        {
            if (ModelState.IsValid)
            {
                return View(stem);
            }
            _stemRepository.Add(stem);
            return RedirectToAction("Create");
        }
    }
}
