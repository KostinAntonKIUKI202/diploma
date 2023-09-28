using Microsoft.AspNetCore.Mvc;
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
    }
}
