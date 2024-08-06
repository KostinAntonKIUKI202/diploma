using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.ViewModels.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class GripsController : Controller
    {
        private readonly IGripsRepository gripsRepository;
        public GripsController(IGripsRepository gripsRepository)
        {
            this.gripsRepository = gripsRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Grips> grips = await gripsRepository.GetAll();
            return View(grips);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var grips = await gripsRepository.GetByIdAsync(id);
            if (grips == null) return View("Error");
            var gripsVM = new EditGripsViewModel()
            {
                GripsId = grips.GripsId,
                GripsName = grips.GripsName,
                GripsQuantity = grips.GripsQuantity
            };
            return View(gripsVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Grips grips)
        {
            if (!ModelState.IsValid)
            {
                return View(grips);
            }
            gripsRepository.Add(grips);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditGripsViewModel gripsVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", gripsVM);
            }
            var editGrips = await gripsRepository.GetByIdAsyncNoTracking(id);
            if (editGrips != null)
            {
                var grips = new Grips
                {
                    GripsId = id,
                    GripsName = gripsVM.GripsName,
                    GripsQuantity = gripsVM.GripsQuantity
                };
                gripsRepository.Update(grips);
                return RedirectToAction("Index");
            }
            else
            {
                return View(gripsVM);
            }
        }
    }
}
