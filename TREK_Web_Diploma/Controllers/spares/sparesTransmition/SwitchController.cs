using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.spares.sparesTransmition
{
    public class SwitchController : Controller
    {
        private readonly ISwitchRepository _switchRepository;
        public SwitchController(ISwitchRepository switchRepository)
        {
            _switchRepository = switchRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Switch> switches = await _switchRepository.GetAll();
            return View(switches);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Switch @switch)
        {
            if (!ModelState.IsValid)
            {
                return View(@switch);
            }
            _switchRepository.Add(@switch);
            return RedirectToAction("Create");
        }
    }
}
