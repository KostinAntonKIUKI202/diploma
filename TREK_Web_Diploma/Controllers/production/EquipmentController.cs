using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Controllers.production
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

        [HttpPost]
        public async Task<IActionResult> Create(Equipment equipment)
        {
            if(!ModelState.IsValid)
            {
                return View(equipment);
            }
            _equipmentRepository.Add(equipment);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Equipment equipment)
        {
            _equipmentRepository.Add(equipment);
            return RedirectToAction("CreateById");
        }
    }
}
