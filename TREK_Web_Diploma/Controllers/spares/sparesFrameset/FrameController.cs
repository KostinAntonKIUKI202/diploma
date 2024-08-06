using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;
using TREK_Web_Diploma.ViewModels.spares.sparesFrameset;

namespace TREK_Web_Diploma.Controllers.spares.sparesFrameset
{
    public class FrameController : Controller
    {
        private readonly IFrameRepository frameRepository;
        public FrameController(IFrameRepository frameRepository)
        {
            this.frameRepository = frameRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Frame> frames = await frameRepository.GetAll();
            return View(frames);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var frame = await frameRepository.GetByIdAsync(id);
            if (frame == null) return View("Error");
            var frameVM = new EditFrameViewModel()
            {
                FrameId = frame.FrameId,
                FrameName = frame.FrameName,
                FrameDescription = frame.FrameDescription,
                FrameQuantity = frame.FrameQuantity,
            };
            return View(frameVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Frame frame)
        {
            if (!ModelState.IsValid)
            {
                return View(frame);
            }
            frameRepository.Add(frame);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditFrameViewModel frameVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", frameVM);
            }
            var editFrame = await frameRepository.GetByIdAsyncNoTracking(id);
            if (editFrame != null)
            {
                var frame = new Frame
                {
                    FrameId = id,
                    FrameName = frameVM.FrameName,
                    FrameDescription = frameVM.FrameDescription,
                    FrameQuantity = frameVM.FrameQuantity,
                };
                frameRepository.Update(frame);
                return RedirectToAction("Index");
            }
            else
            {
                return View(frameVM);
            }
        }
    }
}
