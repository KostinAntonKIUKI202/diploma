using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.ViewModels.spares.sparesEquipment;

namespace TREK_Web_Diploma.Controllers.spares.sparesEquipment
{
    public class SeatPostController : Controller
    {
        private readonly ISeatPostRepository seatPostRepository;
        public SeatPostController(ISeatPostRepository seatPostRepository)
        {
            this.seatPostRepository = seatPostRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<SeatPost> seatPosts = await seatPostRepository.GetAll();
            return View(seatPosts);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var seatPost = await seatPostRepository.GetByIdAsync(id);
            if (seatPost == null) return View("Error");
            var seatPostVM = new EditSeatPostViewModel()
            {
                SeatPostId = seatPost.SeatPostId,
                SeatPostName = seatPost.SeatPostName,
                SeatPostQuantity = seatPost.SeatPostQuantity,
            };
            return View(seatPostVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SeatPost seatPost)
        {
            if (!ModelState.IsValid)
            {
                return View(seatPost);
            }
            seatPostRepository.Add(seatPost);
            return RedirectToAction("Create");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditSeatPostViewModel seatPostVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", seatPostVM);
            }
            var editSeatPost = await seatPostRepository.GetByIdAsyncNoTracking(id);
            if (editSeatPost != null)
            {
                var seatPost = new SeatPost()
                {
                    SeatPostId = id,
                    SeatPostName = seatPostVM.SeatPostName,
                    SeatPostQuantity = seatPostVM.SeatPostQuantity
                };
                seatPostRepository.Update(seatPost);
                return RedirectToAction("Index");
            }
            else 
            { 
                return View(seatPostVM); 
            }
        }
    }
}
