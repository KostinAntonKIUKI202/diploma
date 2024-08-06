using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;
using TREK_Web_Diploma.ViewModels.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.spares.sparesTransmition
{
    public class SwitchController : Controller
    {
        private readonly ISwitchRepository switchRepository;
        public SwitchController(ISwitchRepository switchRepository)
        {
            this.switchRepository = switchRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Switch> switches = await switchRepository.GetAll();
            return View(switches);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var @switch = await switchRepository.GetByIdAsync(id);
            if (@switch == null) return View("Error");
            var switchVM = new EditSwitchViewModel()
            {
                SwitchId = @switch.SwitchId,
                SwitchName = @switch.SwitchName,
                SwitchQuantity = @switch.SwitchQuantity,
            };
            return View(switchVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Switch @switch)
        {
            if (!ModelState.IsValid)
            {
                return View(@switch);
            }
            switchRepository.Add(@switch);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditSwitchViewModel switchVM)
        {
            if(!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Failed to edit");
                return View(switchVM);
            }
            var editSwitch = await switchRepository.GetByIdAsyncNoTracking(id);
            if (editSwitch == null)
            {
                var @switch = new Switch()
                {
                    SwitchId = id,
                    SwitchName = switchVM.SwitchName,
                    SwitchQuantity = switchVM.SwitchQuantity,
                };
                switchRepository.Update(@switch);
                return RedirectToAction("Index");
            }
            else
            {
                return View(switchVM);
            }
        }
    }
}
