using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;
using TREK_Web_Diploma.ViewModels.spares.sparesGroopset;

namespace TREK_Web_Diploma.Controllers.spares.sparesGroopset
{
    public class CarriageController : Controller
    {
        private readonly ICarriageRepository carriageRepository;
        public CarriageController(ICarriageRepository carriageRepository)
        {
            this.carriageRepository = carriageRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Carriage> carriages = await carriageRepository.GetAll();
            return View(carriages);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var carriage = await carriageRepository.GetByIdAsync(id);
            if (carriage == null) return View("Error");
            var carriargeVM = new EditCarriageViewModel
            {
                CarriageId = carriage.CarriageId,
                CarriageName = carriage.CarriageName,
                CarriageQuantity = carriage.CarriageQuantity,
            };
            return View(carriargeVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Carriage carriage)
        {
            if (!ModelState.IsValid)
            {
                return View(carriage);
            }
            carriageRepository.Add(carriage);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditCarriageViewModel carriageVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", carriageVM);
            }
            var editCarriage = await carriageRepository.GetByIdAsyncNoTracking(id);
            if (editCarriage != null)   
            {
                var carriage = new Carriage
                {
                    CarriageId = id,
                    CarriageName = carriageVM.CarriageName,
                    CarriageQuantity = carriageVM.CarriageQuantity
                };
                carriageRepository.Update(carriage);
                return RedirectToAction("Index");
            }
            else
            {
                return View(carriageVM);
            }
        }
    }
}
