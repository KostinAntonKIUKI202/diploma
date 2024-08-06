using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.ViewModels.production;

namespace TREK_Web_Diploma.Controllers.production
{
    public class EquipmentController : Controller
    {
        private readonly IEquipmentRepository equipmentRepository;
        public EquipmentController(IEquipmentRepository equipmentRepository)
        {
            this.equipmentRepository = equipmentRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Equipment> equipment = await equipmentRepository.GetAll();
            return View(equipment);
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
            var equipment = await equipmentRepository.GetByIdAsync(id);
            if (equipment == null) return View("Error");
            var equipmentVM = new EditEquipmentViewModel()
            {
                Brake = new Brake
                {
                    BrakeName = equipment.Brake.BrakeName,
                    BrakeQuantity = equipment.Brake.BrakeQuantity
                },
                Grips = new Grips
                {
                    GripsName = equipment.Grips.GripsName,
                    GripsQuantity = equipment.Grips.GripsQuantity
                },
                Handlebar = new Handlebar
                {
                    HandlebarName = equipment.Handlebar.HandlebarName,
                    HandlebarQuantity = equipment.Handlebar.HandlebarQuantity
                },
                Saddle = new Saddle
                {
                    SaddleName = equipment.Saddle.SaddleName,
                    SaddleQuantity = equipment.Saddle.SaddleQuantity
                },
                SeatPost = new SeatPost
                {
                    SeatPostName = equipment.SeatPost.SeatPostName,
                    SeatPostQuantity = equipment.SeatPost.SeatPostQuantity
                },
                Steering = new Steering
                {
                    SteeringName = equipment.Steering.SteeringName,
                },
                Stem = new Stem
                {
                    StemName = equipment.Stem.StemName,
                    StemQuantity = equipment.Stem.StemQuantity
                }
            };
            return View(equipmentVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Equipment equipment)
        {
            if(!ModelState.IsValid)
            {
                return View(equipment);
            }
            equipmentRepository.Add(equipment);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Equipment equipment)
        {
            equipmentRepository.Add(equipment);
            return RedirectToAction("CreateById");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditEquipmentViewModel equipmentVM)
        {
            if(!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", equipmentVM);
            }

            var editEquipment = await equipmentRepository.GetByIdAsyncNoTracking(id);
            
            if (editEquipment != null)
            {
                var equipment = new Equipment()
                {
                    EquipmentId = id,
                    Brake = new Brake
                    {
                        BrakeName = equipmentVM.Brake.BrakeName,
                        BrakeQuantity = equipmentVM.Brake.BrakeQuantity
                    },
                    Grips = new Grips
                    {
                        GripsName = equipmentVM.Grips.GripsName,
                        GripsQuantity = equipmentVM.Grips.GripsQuantity
                    },
                    Handlebar = new Handlebar
                    {
                        HandlebarName = equipmentVM.Handlebar.HandlebarName,
                        HandlebarQuantity = equipmentVM.Handlebar.HandlebarQuantity
                    },
                    Saddle = new Saddle
                    {
                        SaddleName = equipmentVM.Saddle.SaddleName,
                        SaddleQuantity = equipmentVM.Saddle.SaddleQuantity
                    },
                    SeatPost = new SeatPost
                    {
                        SeatPostName = equipmentVM.SeatPost.SeatPostName,
                        SeatPostQuantity = equipmentVM.SeatPost.SeatPostQuantity
                    },
                    Steering = new Steering
                    {
                        SteeringName = equipmentVM.Steering.SteeringName,
                    },
                    Stem = new Stem
                    {
                        StemName = equipmentVM.Stem.StemName,
                        StemQuantity = equipmentVM.Stem.StemQuantity
                    }
                };
                equipmentRepository.Update(equipment);

                return RedirectToAction("Index");
            }
            else
            {
                return View(equipmentVM);
            }
        }
    }
}
