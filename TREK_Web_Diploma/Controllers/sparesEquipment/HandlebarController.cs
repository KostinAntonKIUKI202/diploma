using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.sparesEquipment
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
    }
}
