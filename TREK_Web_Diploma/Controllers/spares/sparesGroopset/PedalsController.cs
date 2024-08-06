using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;
using TREK_Web_Diploma.ViewModels.spares.sparesGroopset;

namespace TREK_Web_Diploma.Controllers.spares.sparesGroopset
{
    public class PedalsController : Controller
    {
        private readonly IPedalsRepository pedalsRepository;
        public PedalsController(IPedalsRepository pedalsRepository)
        {
            this.pedalsRepository = pedalsRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Pedals> pedals = await pedalsRepository.GetAll();
            return View(pedals);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var pedals = await pedalsRepository.GetByIdAsync(id);
            if (pedals == null) return View("Error");
            var pedalsVM = new EditPedalsViewModel
            {
                PedalsId = pedals.PedalsId,
                PedalsName = pedals.PedalsName,
                PedalsQuantity = pedals.PedalsQuantity,
            };
            return View(pedalsVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pedals pedals)
        {
            if (!ModelState.IsValid)
            {
                return View(pedals);
            }
            pedalsRepository.Add(pedals);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditPedalsViewModel pedalsVM)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", pedalsVM);
            }
            var editPedals = await pedalsRepository.GetByIdAsyncNoTracking(id);
            if (editPedals != null)
            {
                var pedals = new Pedals
                {
                    PedalsId = id,
                    PedalsName = editPedals.PedalsName,
                    PedalsQuantity = editPedals.PedalsQuantity,
                };
                pedalsRepository.Update(pedals);
                return RedirectToAction("Index");
            }
            else
            {
                return View(pedalsVM);
            }
        }
    }
}
