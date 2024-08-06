using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.ViewModels.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class StemController : Controller
    {
        private readonly IStemRepository stemRepository;
        public StemController(IStemRepository stemRepository)
        {
            this.stemRepository = stemRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Stem> stems = await stemRepository.GetAll();
            return View(stems);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var stem = await stemRepository.GetByIdAsync(id);
            if (stem == null) return View("Error");
            var stemVM = new EditStemViewModel()
            {
                StemId = stem.StemId,
                StemName = stem.StemName,
                StemQuantity = stem.StemQuantity,
            };
            return View(stemVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Stem stem)
        {
            if (ModelState.IsValid)
            {
                return View(stem);
            }
            stemRepository.Add(stem);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditStemViewModel stemVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", stemVM);
            }
            var editStem = await stemRepository.GetByIdAsyncNoTracking(id);
            if (editStem != null)
            {
                var stem = new Stem()
                {
                    StemId = id,
                    StemName = stemVM.StemName,
                    StemQuantity = stemVM.StemQuantity,
                };
                stemRepository.Update(stem);
                return RedirectToAction("Index");
            }
            else
            {
                return View(stemVM);
            }
        }
    }
}
