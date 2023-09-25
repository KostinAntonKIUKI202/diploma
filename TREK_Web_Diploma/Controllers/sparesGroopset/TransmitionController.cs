using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.Controllers.sparesGroopset
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
    }
}
