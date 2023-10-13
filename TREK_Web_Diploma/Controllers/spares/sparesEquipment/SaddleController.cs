using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class SaddleController : Controller
    {
        private readonly ISaddleRepository _saddleRepository;
        public SaddleController(ISaddleRepository saddleRepository)
        {
            _saddleRepository = saddleRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Saddle> saddles = await _saddleRepository.GetAll();
            return View(saddles);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Saddle saddle)
        {
            if (!ModelState.IsValid)
            {
                return View(saddle);
            }
            _saddleRepository.Add(saddle);
            return RedirectToAction("Create");
        }
    }
}
