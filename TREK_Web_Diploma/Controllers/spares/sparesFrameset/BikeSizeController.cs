using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Controllers.spares.sparesFrameset
{
    public class BikeSizeController : Controller
    {
        private readonly IBikeSizeRepository _bikeSizeRepository;
        public BikeSizeController(IBikeSizeRepository bikeSizeRepository)
        {
            _bikeSizeRepository = bikeSizeRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<BikeSize> bikeSizes = await _bikeSizeRepository.GetAll();
            return View(bikeSizes);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BikeSize bikeSize)
        {
            if (!ModelState.IsValid)
            {
                return View(bikeSize);
            }
            _bikeSizeRepository.Add(bikeSize);
            return RedirectToAction("Create");
        }
    }
}
