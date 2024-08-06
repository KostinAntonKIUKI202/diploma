using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;
using TREK_Web_Diploma.ViewModels.spares.sparesWheelset;

namespace TREK_Web_Diploma.Controllers.spares.sparesWheelset
{
    public class HubController : Controller
    {
        private readonly IHubRepository hubRepository;
        public HubController(IHubRepository hubRepository)
        {
            this.hubRepository = hubRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Hub> hubs = await hubRepository.GetAll();
            return View(hubs);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var hub = await hubRepository.GetByIdAsync(id);
            if (hub == null) return View("Error");
            var hubVM = new EditHubViewModel()
            {
                HubId = hub.HubId,
                HubName = hub.HubName,
                HubDescription = hub.HubDescription,
                HubQuantity = hub.HubQuantity,
            };
            return View(hubVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Hub hub)
        {
            if (!ModelState.IsValid)
            {
                return View(hub);
            }
            hubRepository.Add(hub);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditHubViewModel hubVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", hubVM);
            }
            var editHub = await hubRepository.GetByIdAsyncNoTracking(id);
            if (editHub == null)
            {
                var hub = new Hub()
                {
                    HubId = id,
                    HubName = hubVM.HubName,
                    HubDescription = hubVM.HubDescription,
                    HubQuantity = hubVM.HubQuantity,
                };
                hubRepository.Update(hub);
                return RedirectToAction("Index");
            }
            else
            {
                return View(hubVM);
            }
        }
    }
}
