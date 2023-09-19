using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers
{
    public class BikesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IBikeRepository _bikeRepository;

        public BikesController(ApplicationDbContext context, IBikeRepository bikeRepository)
        {
            _context = context;
            _bikeRepository = bikeRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Bike> bikes = await _bikeRepository.GetAll();
            return View(bikes);
        }
        public async Task<IActionResult> Detail(int id) 
        { 
            Bike bike = await _bikeRepository.GetByIdAsync(id);
            return View(bike);
        }
    }
}
