using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Controllers
{
    public class BikesController : Controller
    {
        public readonly ApplicationDbContext _context;

        public BikesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Bike> bikes = _context.BikeDB.ToList();
            return View(bikes);
        }
    }
}
