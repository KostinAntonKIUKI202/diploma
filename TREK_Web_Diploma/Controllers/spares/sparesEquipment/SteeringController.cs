using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class SteeringController : Controller
    {
        private readonly ISteeringRepository _steeringRepository;
        public SteeringController(ISteeringRepository steeringRepository)
        {
            _steeringRepository = steeringRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Steering> steerings = await _steeringRepository.GetAll();
            return View(steerings);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Steering steering)
        {
            if (!ModelState.IsValid)
            {
                return View(steering);
            }
            _steeringRepository.Add(steering);
            return RedirectToAction("Create");
        }
    }
}
