using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;
using TREK_Web_Diploma.ViewModels.spares.sparesFrameset;

namespace TREK_Web_Diploma.Controllers.spares.sparesFrameset
{
    public class BikeSizeController : Controller
    {
        private readonly IBikeSizeRepository bikeSizeRepository;
        public BikeSizeController(IBikeSizeRepository bikeSizeRepository)
        {
            this.bikeSizeRepository = bikeSizeRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<BikeSize> bikeSizes = await bikeSizeRepository.GetAll();
            return View(bikeSizes);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id) 
        {
            var bikeSize = await bikeSizeRepository.GetByIdAsync(id);
            if (bikeSize == null) return View("Error");
            var bikeSizeVM = new EditBikeSizeViewModel()
            {
                BikeSizeId = bikeSize.BikeSizeId,
                BikeSizeName = bikeSize.BikeSizeName
            };
            return View(bikeSizeVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BikeSize bikeSize)
        {
            if (!ModelState.IsValid)
            {
                return View(bikeSize);
            }
            bikeSizeRepository.Add(bikeSize);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditBikeSizeViewModel bikeSizeVM)
        {
            if (!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", bikeSizeVM);
            }
            var editBikeSize = await bikeSizeRepository.GetByIdAsyncNoTracking(id);
            if (editBikeSize != null)
            {
                var bikeSize = new BikeSize
                {
                    BikeSizeId = id,
                    BikeSizeName = bikeSizeVM.BikeSizeName,
                };
                bikeSizeRepository.Update(bikeSize);
                return RedirectToAction("Index");
            }
            else
            {
                return View(bikeSizeVM);
            }
        }
    }
}
