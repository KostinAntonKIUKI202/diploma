using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.ViewModels.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class HandlebarController : Controller
    {
        private readonly IHandlebarRepository handlebarRepository;
        public HandlebarController(IHandlebarRepository handlebarRepository)
        {
            this.handlebarRepository = handlebarRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Handlebar> handlebars = await handlebarRepository.GetAll();
            return View(handlebars);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var handlebar = await handlebarRepository.GetByIdAsync(id);
            if (handlebar == null) return View("Error");
            var handlebarVM = new EditHandlebarViewModel() 
            {
                HandlebarId = handlebar.HandlebarId,
                HandlebarName = handlebar.HandlebarName,
                HandlebarQuantity = handlebar.HandlebarQuantity,
            };
            return View(handlebarVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Handlebar handlebar)
        {
            if(!ModelState.IsValid)
            {
                return View(handlebar);
            }
            handlebarRepository.Add(handlebar);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditHandlebarViewModel handlebarVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", handlebarVM);
            }
            var editHandlebar = await handlebarRepository.GetByIdAsyncNoTracking(id);
            if (editHandlebar != null)
            {
                var handlebar = new Handlebar()
                {
                    HandlebarId = id,
                    HandlebarName = handlebarVM.HandlebarName,
                    HandlebarQuantity = handlebarVM.HandlebarQuantity,
                };
                handlebarRepository.Update(handlebar);
                return RedirectToAction("Index");
            }
            else
            {
                return View(handlebarVM);
            }
        }
    }
}
