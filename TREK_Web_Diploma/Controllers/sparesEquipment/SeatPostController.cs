using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.sparesEquipment
{
    public class SeatPostController : Controller
    {
        private readonly ISeatPostRepository _seatPostRepository;
        public SeatPostController(ISeatPostRepository seatPostRepository)
        {
            _seatPostRepository = seatPostRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<SeatPost> seatPosts = await _seatPostRepository.GetAll();
            return View(seatPosts);
        }
        public IActionResult Create() 
        {
            return View();
        }
    }
}
