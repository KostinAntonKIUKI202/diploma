using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.ViewModels.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class SteeringController : Controller
    {
        private readonly ISteeringRepository steeringRepository;
        public SteeringController(ISteeringRepository steeringRepository)
        {
            this.steeringRepository = steeringRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Steering> steerings = await steeringRepository.GetAll();
            return View(steerings);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var steering = await steeringRepository.GetByIdAsync(id);
            if (steering == null) return View("Error");
            var steeringVM = new EditSteeringViewModel()
            {
                SteeringId = steering.SteeringId,
                SteeringName = steering.SteeringName
            };
            return View(steeringVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Steering steering)
        {
            if (!ModelState.IsValid)
            {
                return View(steering);
            }
            steeringRepository.Add(steering);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditSteeringViewModel steeringVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", steeringVM);
            }
            var editSteering = await steeringRepository.GetByIdAsyncNoTracking(id);
            if (editSteering != null)
            {
                var steering = new Steering()
                {
                    SteeringId = id,
                    SteeringName = steeringVM.SteeringName,
                };
                steeringRepository.Update(steering);
                return RedirectToAction("Index");
            }
            else
            {
                return View(steeringVM);
            }
        }
    }
}
