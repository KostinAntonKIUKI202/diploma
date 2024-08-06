using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;
using TREK_Web_Diploma.ViewModels.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.spares.sparesTransmition
{
    public class CassetteController : Controller
    {
        private readonly ICassetteRepository cassetteRepository;
        public CassetteController(ICassetteRepository cassetteRepository)
        {
            this.cassetteRepository = cassetteRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Cassette> cassettes = await cassetteRepository.GetAll();
            return View(cassettes);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var cassette = await cassetteRepository.GetByIdAsync(id);
            if (cassette == null) return View("Error");
            var cassetteVM = new EditCassetteViewModel()
            {
                CassetteId = cassette.CassetteId,
                CassetteName = cassette.CassetteName,
                CassetteQuantity = cassette.CassetteQuantity,
            };
            return View(cassetteVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Cassette cassette)
        {
            if (!ModelState.IsValid)
            {
                return View(cassette);
            }
            cassetteRepository.Add(cassette);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditCassetteViewModel cassetteVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", cassetteVM);
            }
            var editCassette = await cassetteRepository.GetByIdAsyncNoTracking(id);
            if (editCassette != null)
            {
                var cassette = new Cassette
                {
                    CassetteId = id,
                    CassetteName = cassetteVM.CassetteName,
                    CassetteQuantity = cassetteVM.CassetteQuantity,
                };
                return RedirectToAction("Index");
            }
            else
            {
                return View(cassetteVM);
            }
        }
    }
}
