using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Data;

namespace TREK_Web_Diploma.Controllers
{
    public class StaffController : Controller
    {
        public readonly ApplicationDbContext _context;
        public StaffController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var staff = _context.StaffDB.ToList();
            return View(staff);
        }
    }
}
