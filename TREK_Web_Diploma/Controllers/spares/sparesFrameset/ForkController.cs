using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;
using TREK_Web_Diploma.ViewModels.spares.sparesFrameset;

namespace TREK_Web_Diploma.Controllers.spares.sparesFrameset
{
    public class ForkController : Controller
    {
        private readonly IForkRepository forkRepository;
        public ForkController(IForkRepository forkRepository)
        {
            this.forkRepository = forkRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Fork> forks = await forkRepository.GetAll();
            return View(forks);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var fork = await forkRepository.GetByIdAsync(id);
            if (fork == null) return View("Error");
            var forkVM = new EditForkViewModel()
            {
                ForkId = fork.ForkId,
                ForkName = fork.ForkName,
                ForkDescription = fork.ForkDescription,
                ForkQuantity = fork.ForkQuantity,
            };
            return View(forkVM);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Fork fork)
        {
            if (!ModelState.IsValid)
            {
                return View(fork);
            }
            forkRepository.Add(fork);
            return RedirectToAction("Create");
        }
        [HttpPost]
        async Task<IActionResult> Edit(int id, EditForkViewModel forkVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("", forkVM);
            }
            var editFork = await forkRepository.GetByIdAsyncNoTracking(id);
            if(editFork != null)
            {
                var fork = new Fork
                {
                    ForkId = id,
                    ForkName = forkVM.ForkName,
                    ForkDescription = forkVM.ForkDescription,
                    ForkQuantity = forkVM.ForkQuantity,
                };
                forkRepository.Update(fork);
                return RedirectToAction("Index");
            }
            else 
            {
                return View(forkVM); 
            }
        }
    }
}
