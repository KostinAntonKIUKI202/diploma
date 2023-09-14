using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TREK_Web_Diploma.Data;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.Models.spares.sparesEquipment;

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
        public IActionResult Detail(int id) 
        { 
            Bike bike = _context.BikeDB
                .Include(a => a.Equipment)
                .Include(a => a.Frameset)
                .Include(a => a.Groopset)
                .Include(a => a.Wheelset)
                .Include(a => a.Equipment.Brake)
                .Include(a => a.Equipment.Grips)
                .Include(a => a.Equipment.Handlebar)
                .Include(a => a.Equipment.Saddle)
                .Include(a => a.Equipment.SeatPost)
                .Include(a => a.Equipment.Steering)
                .Include(a => a.Equipment.Stem)
                .Include(a => a.Frameset.BikeSize)
                .Include(a => a.Frameset.Frame)
                .Include(a => a.Frameset.Fork)
                .Include(a => a.Groopset.Transmition)
                .Include(a => a.Groopset.Transmition.FrontGear)
                .Include(a => a.Groopset.Transmition.Switch)
                .Include(a => a.Groopset.Transmition.Cassette)
                .Include(a => a.Groopset.Transmition.Shifter)
                .Include(a => a.Groopset.Pedals)
                .Include(a => a.Groopset.Carriage)
                .Include(a => a.Wheelset.Hub)
                .Include(a => a.Wheelset.Rim)
                .Include(a => a.Wheelset.Tire)
                .FirstOrDefault(c => c.BikeId == id);
            return View(bike);
        }
    }
}
