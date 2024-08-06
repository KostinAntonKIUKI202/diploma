using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.Models.spares.sparesFrameset;
using TREK_Web_Diploma.ViewModels.production;

namespace TREK_Web_Diploma.Controllers.production
{
    public class FramesetController : Controller
    {
        private readonly IFramesetRepository framesetRepository;
        public FramesetController(IFramesetRepository framesetRepository)
        {
            this.framesetRepository = framesetRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Frameset> framesets = await framesetRepository.GetAll();
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

        public async Task<IActionResult> Edit(int id)
        {
            var frameset = await framesetRepository.GetByIdAsync(id);
            if (frameset == null) return View("Error");
            var framesetVM = new EditFramesetViewModel
            {
                BikeSize = new BikeSize
                {
                    BikeSizeName = frameset.BikeSize.BikeSizeName
                },
                Frame = new Frame
                {
                    FrameName = frameset.Frame.FrameName,
                    FrameDescription = frameset.Frame.FrameDescription,
                    FrameQuantity = frameset.Frame.FrameQuantity
                },
                Fork = new Fork
                {
                    ForkName = frameset.Fork.ForkName,
                    ForkDescription = frameset.Fork.ForkDescription,
                    ForkQuantity = frameset.Fork.ForkQuantity
                }

            };
            return View(framesetVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Frameset frameset)
        {
            if (!ModelState.IsValid)
            {
                return View(frameset); 
            }
            framesetRepository.Add(frameset);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Frameset frameset)
        {
            if (!ModelState.IsValid)
            {
                return View(frameset);
            }
            framesetRepository.Add(frameset);
            return RedirectToAction("CreateById");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditFramesetViewModel framesetVM)
        {
            if (!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", framesetVM);
            }

            var editFrameset = await framesetRepository.GetByIdAsyncNoTracking(id);
            if (editFrameset != null)
            {
                var frameset = new Frameset
                {
                    BikeSize = new BikeSize
                    {
                        BikeSizeName = framesetVM.BikeSize.BikeSizeName
                    },
                    Frame = new Frame
                    {
                        FrameName = framesetVM.Frame.FrameName,
                        FrameDescription = framesetVM.Frame.FrameDescription,
                        FrameQuantity = framesetVM.Frame.FrameQuantity
                    },
                    Fork = new Fork
                    {
                        ForkName = framesetVM.Fork.ForkName,
                        ForkDescription = framesetVM.Fork.ForkDescription,
                        ForkQuantity = framesetVM.Fork.ForkQuantity
                    }
                };
                framesetRepository.Update(frameset);
                return RedirectToAction("Index");
            }
            else
            {
                return View(framesetVM);
            }
        }
    }
}
