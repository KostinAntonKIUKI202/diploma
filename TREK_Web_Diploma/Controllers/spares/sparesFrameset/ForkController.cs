using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Controllers.spares.sparesFrameset
{
    public class ForkController : Controller
    {
        private readonly IForkRepository _forkRepository;
        public ForkController(IForkRepository forkRepository)
        {
            _forkRepository = forkRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Fork> forks = await _forkRepository.GetAll();
            return View(forks);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Fork fork)
        {
            if (!ModelState.IsValid)
            {
                return View(fork);
            }
            _forkRepository.Add(fork);
            return RedirectToAction("Create");
        }
    }
}
