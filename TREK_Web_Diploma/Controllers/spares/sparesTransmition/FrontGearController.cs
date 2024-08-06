using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;
using TREK_Web_Diploma.ViewModels.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.spares.sparesTransmition
{
    public class FrontGearController : Controller
    {
        private readonly IFrontGearRepository frontGearRepository;
        public FrontGearController(IFrontGearRepository frontGearRepository)
        {
            this.frontGearRepository = frontGearRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<FrontGear> frontGears = await frontGearRepository.GetAll();
            return View(frontGears);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var frontGear = await frontGearRepository.GetByIdAsync(id);
            if (frontGear == null) return View("Error");
            var frontGearVM = new EditFrontGearViewModel()
            {
                FrontGearId = frontGear.FrontGearId,
                FrontGearName = frontGear.FrontGearName,
                FrontGearQuantity = frontGear.FrontGearQuantity,
            };
            return View(frontGearVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(FrontGear frontGear)
        {
            if (!ModelState.IsValid)
            {
                return View(frontGear);
            }
            frontGearRepository.Add(frontGear);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditFrontGearViewModel frontGearVM)
        {
            if (!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", frontGearVM);
            }
            var editFrontGear = await frontGearRepository.GetByIdAsyncNoTracking(id);
            if (editFrontGear == null)
            {
                var frontGear = new FrontGear()
                {
                    FrontGearId = id,
                    FrontGearName = frontGearVM.FrontGearName,
                    FrontGearQuantity = frontGearVM.FrontGearQuantity,
                };
                frontGearRepository.Update(frontGear);
                return RedirectToAction("Index");
            }
            else 
            {
                return View(frontGearVM);
            }
        }
    }
}
