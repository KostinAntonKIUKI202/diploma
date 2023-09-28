using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Controllers.production
{
    public class WheelsetController : Controller
    {
        private readonly IWheelsetRepository _wheelsetRepository;
        public WheelsetController(IWheelsetRepository wheelset)
        {
            _wheelsetRepository = wheelset;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Wheelset> wheelsets = await _wheelsetRepository.GetAll();
            return View(wheelsets);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
