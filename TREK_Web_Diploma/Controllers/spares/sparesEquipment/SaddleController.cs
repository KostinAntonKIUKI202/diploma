using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.ViewModels.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class SaddleController : Controller
    {
        private readonly ISaddleRepository saddleRepository;
        public SaddleController(ISaddleRepository saddleRepository)
        {
            this.saddleRepository = saddleRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Saddle> saddles = await saddleRepository.GetAll();
            return View(saddles);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var saddle = await saddleRepository.GetByIdAsync(id);
            if (saddle == null) return View("Error");
            var saddleVM = new EditSaddleViewModel()
            {
                SaddleId = saddle.SaddleId,
                SaddleName = saddle.SaddleName,
                SaddleQuantity = saddle.SaddleQuantity,
            };
            return View(saddleVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Saddle saddle)
        {
            if (!ModelState.IsValid)
            {
                return View(saddle);
            }
            saddleRepository.Add(saddle);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditSaddleViewModel saddleVM)
        {
            if (!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", saddleVM);
            }
            var editSaddle = await saddleRepository.GetByIdAsyncNoTracking(id);
            if (editSaddle != null)
            {
                var saddle = new Saddle()
                {
                    SaddleId = id,
                    SaddleName = saddleVM.SaddleName,
                    SaddleQuantity = saddleVM.SaddleQuantity
                };
                saddleRepository.Update(saddle);
                return RedirectToAction("Index");
            }
            else
            {
                return View(saddleVM);
            }
        }
    }
}
