using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Controllers.spares.sparesFrameset
{
    public class FrameController : Controller
    {
        private readonly IFrameRepository _frameRepository;
        public FrameController(IFrameRepository frameRepository)
        {
            _frameRepository = frameRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Frame> frames = await _frameRepository.GetAll();
            return View(frames);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Frame frame)
        {
            if (!ModelState.IsValid)
            {
                return View(frame);
            }
            _frameRepository.Add(frame);
            return RedirectToAction("Create");
        }   
    }
}
