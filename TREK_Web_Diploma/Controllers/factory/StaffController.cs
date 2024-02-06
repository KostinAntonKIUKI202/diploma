using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.factory;
using TREK_Web_Diploma.Models.factory;

namespace TREK_Web_Diploma.Controllers.factory
{
    public class StaffController : Controller
    {
        public readonly IStaffRepository _staffRepository;
        public StaffController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Staff> staff = await _staffRepository.GetAll();
            return View(staff);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Staff staff = await _staffRepository.GetByIdAsync(id);
            return View(staff);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateById()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return View(staff);
            }
            _staffRepository.Add(staff);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return View(staff);
            }
            _staffRepository.Add(staff);
            return RedirectToAction("CreateById");
        }
    }
}
