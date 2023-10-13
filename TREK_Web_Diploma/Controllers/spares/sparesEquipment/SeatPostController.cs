using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
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

        [HttpPost]
        public async Task<IActionResult> Create(SeatPost seatPost)
        {
            if (!ModelState.IsValid)
            {
                return View(seatPost);
            }
            _seatPostRepository.Add(seatPost);
            return RedirectToAction("Create");
        }
    }
}
