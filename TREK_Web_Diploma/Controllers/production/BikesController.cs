using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.ViewModels;

namespace TREK_Web_Diploma.Controllers.production
{
    public class BikesController : Controller
    {
        private readonly IBikeRepository _bikeRepository;
        private readonly IPhotoService _photoService;
        public BikesController(IBikeRepository bikeRepository, IPhotoService photoService)
        {
            _bikeRepository = bikeRepository;
            _photoService = photoService;
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
        public IActionResult CreateById()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBikeViewModel bikeVM)
        {
            if(ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(bikeVM.BikeImage);

                Bike bike = new()
                {
                    BikeName = bikeVM.BikeName,
                    BikeImage = result.Url.ToString(),
                    BikeDescription = bikeVM.BikeDescription,
                    BikePrice = bikeVM.BikePrice,
                    BikeWeight = bikeVM.BikeWeight,
                    Frameset = bikeVM.Frameset,
                    Wheelset = bikeVM.Wheelset,
                    Groopset = bikeVM.Groopset,
                    Equipment = bikeVM.Equipment,
                    TypeOfBike = bikeVM.TypeOfBike
                };
                _bikeRepository.Add(bike);
                return RedirectToAction("Create");
            }
            else
            {
                ModelState.AddModelError("", "Фото не завантажилося");
            }
            return View(bikeVM);
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(CreateBikeViewModel bikeVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _photoService.AddPhotoAsync(bikeVM.BikeImage);
                var bike = new Bike
                {
                    BikeName = bikeVM.BikeName,
                    BikeImage = result.Url.ToString(),
                    BikeDescription = bikeVM.BikeDescription,
                    BikePrice = bikeVM.BikePrice,
                    BikeWeight = bikeVM.BikeWeight,
                    FramesetId = bikeVM.FramesetId,
                    WheelsetId = bikeVM.WheelsetId,
                    GroopsetId = bikeVM.GroopsetId,
                    EquipmentId = bikeVM.EquipmentId,
                    TypeOfBike = bikeVM.TypeOfBike
                };
                _bikeRepository.Add(bike);
                return RedirectToAction("CreateById");
            }
            else
            {
                ModelState.AddModelError("", "Фото не завантажилося");
            }
            return View(bikeVM);
        }
    }
}
