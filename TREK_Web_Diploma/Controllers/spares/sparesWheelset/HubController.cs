using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesWheelset;
using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.Controllers.spares.sparesWheelset
{
    public class HubController : Controller
    {
        private readonly IHubRepository _hubRepository;
        public HubController(IHubRepository hubRepository)
        {
            _hubRepository = hubRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Hub> hubs = await _hubRepository.GetAll();
            return View(hubs);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Hub hub)
        {
            if(!ModelState.IsValid)
            {
                return View(hub);
            }
            _hubRepository.Add(hub);
            return RedirectToAction("Index");
        }
    }
}
