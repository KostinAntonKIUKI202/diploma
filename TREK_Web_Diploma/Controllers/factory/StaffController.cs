using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.factory;
using TREK_Web_Diploma.Models.factory;
using TREK_Web_Diploma.ViewModels;

namespace TREK_Web_Diploma.Controllers.factory
{
    public class StaffController : Controller
    {
        public readonly IStaffRepository staffRepository;
        public StaffController(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Staff> staff = await staffRepository.GetAll();
            return View(staff);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Staff staff = await staffRepository.GetByIdAsync(id);
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

        public async Task<IActionResult> Edit(int id)
        {
            var staff = await staffRepository.GetByIdAsync(id);
            if (staff == null) return View("Error");
            var staffVM = new EditStaffViewModel()
            {
                StaffId = staff.StaffId,
                FirstName = staff.FirstName,
                SecondName = staff.SecondName,
                JobTitle = new JobTitle
                {
                    JobTitleName = staff.JobTitle.JobTitleName,
                },
                FactoryId = staff.FactoryId,
            };
            return View(staffVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return View(staff);
            }
            staffRepository.Add(staff);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return View(staff);
            }
            staffRepository.Add(staff);
            return RedirectToAction("CreateById");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditStaffViewModel staffVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", staffVM);
            }
            var editStaff = await staffRepository.GetByIdAsyncNoTracking(id);
            if(editStaff != null)
            {
                var staff = new Staff
                {
                    StaffId = id,
                    FirstName = staffVM.FirstName,
                    SecondName = staffVM.SecondName,
                    JobTitle = new JobTitle
                    {
                        JobTitleName = staffVM.JobTitle.JobTitleName,
                    },
                    FactoryId = staffVM.FactoryId
                };
                staffRepository.Update(staff);
                return RedirectToAction("Index");
            }
            else
            {
                return View(staffVM);
            }
        }
    }
}
