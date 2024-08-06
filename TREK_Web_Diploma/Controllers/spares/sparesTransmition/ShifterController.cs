using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;
using TREK_Web_Diploma.ViewModels.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.spares.sparesTransmition
{
    public class ShifterController : Controller
    {
        private readonly IShifterRepository shifterRepository;
        public ShifterController(IShifterRepository shifterRepository)
        {
            this.shifterRepository = shifterRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Shifter> shifters = await shifterRepository.GetAll();
            return View(shifters);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var shifter = await shifterRepository.GetByIdAsync(id);
            if (shifter == null) return View("Error");
            var shifterVM = new EditShifterViewModel()
            {
                ShifterId = shifter.ShifterId,
                ShifterName = shifter.ShifterName,
                ShifterQuantity = shifter.ShifterQuantity,
            };
            return View(shifterVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Shifter shifter)
        {
            if(!ModelState.IsValid) 
            {
                return View(shifter);
            }
            shifterRepository.Add(shifter);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditShifterViewModel shifterVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", shifterVM);
            }
            var editShifter = await shifterRepository.GetByIdAsyncNoTracking(id);
            if (editShifter == null)
            {
                var shifter = new Shifter()
                {
                    ShifterId = id,
                    ShifterName = shifterVM.ShifterName,
                    ShifterQuantity = shifterVM.ShifterQuantity,
                };
                shifterRepository.Update(shifter);
                return RedirectToAction("Index");
            }
            else
            {
                return View(shifterVM);
            }
        }
    }
}
