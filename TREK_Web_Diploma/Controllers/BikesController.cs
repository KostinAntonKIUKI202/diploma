using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.Controllers
{
    public class BikesController : Controller
    {
        private readonly IBikeRepository _bikeRepository;
        public BikesController(IBikeRepository bikeRepository)
        {
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
        public IActionResult Create()
        {
            return View();
        }
    }
}
