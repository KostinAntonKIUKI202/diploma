using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.ViewModels.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class BrakeController : Controller
    {
        private readonly IBrakeRepository brakeRepository;
        public BrakeController(IBrakeRepository brakeRepository)
        {
            this.brakeRepository = brakeRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Brake> brakes = await brakeRepository.GetAll();
            return View(brakes);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var brake = await brakeRepository.GetByIdAsync(id);
            if (brake == null) return View("Error");
            var brakeVM = new EditBrakeViewModel()
            {
                BrakeId = brake.BrakeId,
                BrakeName = brake.BrakeName,
                BrakeQuantity = brake.BrakeQuantity,
            };
            return View(brakeVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Brake brake)
        {
            if(!ModelState.IsValid)
            {
                return View(brake);
            }
            brakeRepository.Add(brake);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditBrakeViewModel brakeVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View(brakeVM);
            }
            var editBrake = await brakeRepository.GetByIdAsyncNoTracking(id);
            if (editBrake != null) 
            {
                var brake = new Brake()
                {
                    BrakeId = id,
                    BrakeName = brakeVM.BrakeName,
                    BrakeQuantity = brakeVM.BrakeQuantity,
                };
                brakeRepository.Update(brake);
                return RedirectToAction("Index");
            }
            else
            {
                return View(brakeVM);
            }
        }
    }
}
