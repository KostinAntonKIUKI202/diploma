using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class HandlebarController : Controller
    {
        private readonly IHandlebarRepository _handlebarRepository;
        public HandlebarController(IHandlebarRepository handlebarRepository)
        {
            _handlebarRepository = handlebarRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Handlebar> handlebars = await _handlebarRepository.GetAll();
            return View(handlebars);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Handlebar handlebar)
        {
            if(!ModelState.IsValid)
            {
                return View(handlebar);
            }
            _handlebarRepository.Add(handlebar);
            return RedirectToAction("Create");
        }
    }
}
