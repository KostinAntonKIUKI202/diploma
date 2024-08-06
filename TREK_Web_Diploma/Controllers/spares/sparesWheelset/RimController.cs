using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;
using TREK_Web_Diploma.ViewModels.spares.sparesWheelset;

namespace TREK_Web_Diploma.Controllers.spares.sparesWheelset
{
    public class RimController : Controller
    {
        private readonly IRimRepository rimRepository;
        public RimController(IRimRepository rimRepository)
        {
            this.rimRepository = rimRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Rim> rims = await rimRepository.GetAll();
            return View(rims);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var rim = await rimRepository.GetByIdAsync(id);
            if (rim == null) return View("Error");
            var rimVM = new EditRimViewModel()
            {
                RimId = rim.RimId,
                RimName = rim.RimName,
                RimDescription = rim.RimDescription,
                RimQuantity = rim.RimQuantity,
            };
            return View(rimVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Rim rim)
        {
            if (!ModelState.IsValid)
            {
                return View(rim);
            }
            rimRepository.Add(rim);
            return RedirectToAction("Create");
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditRimViewModel rimVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", rimVM);
            }
            var editRim = await rimRepository.GetByIdAsyncNoTracking(id);
            if (editRim == null)
            {
                var rim = new Rim()
                {
                    RimId = id,
                    RimName = rimVM.RimName,
                    RimDescription = rimVM.RimDescription,
                    RimQuantity = rimVM.RimQuantity,
                };
                rimRepository.Update(rim);
                return RedirectToAction("Index");
            }
            else
            {
                return View(rimVM);
            }
        }
    }
}
