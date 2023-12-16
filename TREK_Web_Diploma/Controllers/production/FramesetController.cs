using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Controllers.production
{
    public class FramesetController : Controller
    {
        private readonly IFramesetRepository _framesetRepository;
        public FramesetController(IFramesetRepository framesetRepository)
        {
            _framesetRepository = framesetRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Frameset> framesets = await _framesetRepository.GetAll();
            return View(framesets);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateById()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Frameset frameset)
        {
            if (!ModelState.IsValid)
            {
                return View(frameset); 
            }
            _framesetRepository.Add(frameset);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Frameset frameset)
        {
            if (!ModelState.IsValid)
            {
                return View(frameset);
            }
            _framesetRepository.Add(frameset);
            return RedirectToAction("CreateById");
        }
    }
}
