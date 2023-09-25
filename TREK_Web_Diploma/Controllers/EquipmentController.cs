using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly IEquipmentRepository _equipmentRepository;
        public EquipmentController(IEquipmentRepository equipmentRepository) 
        {
            _equipmentRepository = equipmentRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Equipment> equipment = await _equipmentRepository.GetAll();
            return View(equipment);
        }
        public IActionResult Create() 
        {
            return View();
        }
    }
}
