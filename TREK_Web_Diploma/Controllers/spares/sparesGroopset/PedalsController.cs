using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Controllers.spares.sparesGroopset
{
    public class PedalsController : Controller
    {
        private readonly IPedalsRepository _petalsRepository;
        public PedalsController(IPedalsRepository pedalsRepository)
        {
            _petalsRepository = pedalsRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Pedals> pedals = await _petalsRepository.GetAll();
            return View(pedals);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Pedals pedals)
        {
            if (!ModelState.IsValid)
            {
                return View(pedals);
            }
            _petalsRepository.Add(pedals);
            return RedirectToAction("Create");
        }
    }
}
