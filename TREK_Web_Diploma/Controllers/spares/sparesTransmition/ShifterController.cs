using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
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

        [HttpPost]
        public async Task<IActionResult> Create(Shifter shifter)
        {
            if(!ModelState.IsValid) 
            {
                return View(shifter);
            }
            _shifterRepository.Add(shifter);
            return RedirectToAction("Create");
        }
    }
}
