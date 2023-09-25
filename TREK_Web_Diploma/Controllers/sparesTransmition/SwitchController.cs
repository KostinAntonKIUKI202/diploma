using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Controllers.sparesTransmition
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
    }
}
