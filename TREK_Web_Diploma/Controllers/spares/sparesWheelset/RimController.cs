using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Controllers.spares.sparesWheelset
{
    public class RimController : Controller
    {
        private readonly IRimRepository _rimRepository;
        public RimController(IRimRepository rimRepository)
        {
            _rimRepository = rimRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Rim> rims = await _rimRepository.GetAll();
            return View(rims);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Rim rim)
        {
            if (!ModelState.IsValid)
            {
                return View(rim);
            }
            _rimRepository.Add(rim);
            return RedirectToAction("Create");
        }
    }
}
