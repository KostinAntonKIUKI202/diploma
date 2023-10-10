using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Controllers.spares.sparesGroopset
{
    public class TransmitionController : Controller
    {
        private readonly ITransmitionRepository _transmitionRepository;
        public TransmitionController(ITransmitionRepository transmitionRepository)
        {
            _transmitionRepository = transmitionRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Transmition> transmitions = await _transmitionRepository.GetAll();
            return View(transmitions);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult CreateById()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Transmition transmition)
        {
            if (!ModelState.IsValid)
            {
                return View(transmition);
            }
            _transmitionRepository.Add(transmition);
            return RedirectToAction("Index");
        }
    }
}
