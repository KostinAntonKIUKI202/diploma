using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;
using TREK_Web_Diploma.ViewModels.spares.sparesWheelset;

namespace TREK_Web_Diploma.Controllers.spares.sparesWheelset
{
    public class TireController : Controller
    {
        private readonly ITireRepository tireRepository;
        public TireController(ITireRepository tireRepository)
        {
            this.tireRepository = tireRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Tire> tires = await tireRepository.GetAll();
            return View(tires);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var tire = await tireRepository.GetByIdAsync(id);
            if (tire == null) return View("Error");
            var tireVM = new EditTireViewModel()
            {
                TireId = tire.TireId,
                TireName = tire.TireName,
                TireDescription = tire.TireDescription,
                TireQuantity = tire.TireQuantity,
            };
            return View(tireVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tire tire)
        {
            if (!ModelState.IsValid)
            {
                return View(tire);
            }
            tireRepository.Add(tire);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditTireViewModel tireVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", tireVM);
            }
            var editTire = await tireRepository.GetByIdAsyncNoTracking(id);
            if (editTire == null)
            {
                var tire = new Tire()
                {
                    TireId = id,
                    TireName = tireVM.TireName,
                    TireDescription = tireVM.TireDescription,
                    TireQuantity = tireVM.TireQuantity,
                };
                tireRepository.Update(tire);
                return View(tireVM);
            }
            else
            {
                return View(tireVM);
            }
        }
    }
}
