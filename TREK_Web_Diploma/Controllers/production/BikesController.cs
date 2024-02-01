using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TREK_Web_Diploma.Interfaces;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.Models.spares.sparesEquipment;
using TREK_Web_Diploma.Models.spares.sparesFrameset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesTransmition;
using TREK_Web_Diploma.Models.spares.sparesWheelset;
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

        public async Task<IActionResult> Edit(int id)
        {
            var bike = await _bikeRepository.GetByIdAsync(id);
            if (bike == null) return View("Error");
            var bikeVM = new EditBikeViewModel()
            {
                BikeName = bike.BikeName,
                URL = bike.BikeImage,
                BikeDescription = bike.BikeDescription,
                BikePrice = bike.BikePrice,
                BikeWeight = bike.BikeWeight,
                FramesetId = bike.FramesetId,
                Frameset = new Frameset
                {
                    BikeSize = new BikeSize
                    {
                        BikeSizeName = bike.Frameset.BikeSize.BikeSizeName
                    },
                    Frame = new Frame
                    {
                        FrameName = bike.Frameset.Frame.FrameName,
                        FrameDescription = bike.Frameset.Frame.FrameDescription,
                        FrameQuantity = bike.Frameset.Frame.FrameQuantity
                    },
                    Fork = new Fork
                    {
                        ForkName = bike.Frameset.Fork.ForkName,
                        ForkDescription = bike.Frameset.Fork.ForkDescription,
                        ForkQuantity = bike.Frameset.Fork.ForkQuantity
                    }
                },
                WheelsetId = bike.WheelsetId,
                Wheelset = new Wheelset
                {
                    Tire = new Tire
                    {
                        TireName = bike.Wheelset.Tire.TireName,
                        TireDescription = bike.Wheelset.Tire.TireDescription,
                        TireQuantity = bike.Wheelset.Tire.TireQuantity
                    },
                    Rim = new Rim
                    {
                        RimName = bike.Wheelset.Rim.RimName,
                        RimDescription = bike.Wheelset.Rim.RimDescription,
                        RimQuantity = bike.Wheelset.Rim.RimQuantity
                    },
                    Hub = new Hub
                    {
                        HubName = bike.Wheelset.Hub.HubName,
                        HubDescription = bike.Wheelset.Hub.HubDescription,
                        HubQuantity = bike.Wheelset.Hub.HubQuantity
                    }
                },
                GroopsetId = bike.GroopsetId,
                Groopset = new Groopset
                {
                    Transmition = new Transmition
                    {
                        Cassette = new Cassette
                        {
                            CassetteName = bike.Groopset.Transmition.Cassette.CassetteName,
                            CassetteQuantity = bike.Groopset.Transmition.Cassette.CassetteQuantity
                        },
                        Switch = new Switch
                        {
                            SwitchName = bike.Groopset.Transmition.Switch.SwitchName,
                            SwitchQuantity = bike.Groopset.Transmition.Switch.SwitchQuantity
                        },
                        Shifter = new Shifter
                        {
                            ShifterName = bike.Groopset.Transmition.Shifter.ShifterName,
                            ShifterQuantity = bike.Groopset.Transmition.Shifter.ShifterQuantity
                        },
                        FrontGear = new FrontGear
                        {
                            FrontGearName = bike.Groopset.Transmition.FrontGear.FrontGearName,
                            FrontGearQuantity = bike.Groopset.Transmition.FrontGear.FrontGearQuantity
                        }
                    },
                    Carriage = new Carriage
                    {
                        CarriageName = bike.Groopset.Carriage.CarriageName,
                        CarriageQuantity = bike.Groopset.Carriage.CarriageQuantity
                    },
                    Pedals = new Pedals
                    {
                        PedalsName = bike.Groopset.Pedals.PedalsName,
                        PedalsQuantity = bike.Groopset.Pedals.PedalsQuantity
                    }
                },
                EquipmentId = bike.EquipmentId,
                Equipment = new Equipment
                {
                    Brake = new Brake
                    {
                        BrakeName = bike.Equipment.Brake.BrakeName,
                        BrakeQuantity = bike.Equipment.Brake.BrakeQuantity
                    },
                    Grips = new Grips
                    {
                        GripsName = bike.Equipment.Grips.GripsName,
                        GripsQuantity = bike.Equipment.Grips.GripsQuantity
                    },
                    Handlebar = new Handlebar
                    {
                        HandlebarName = bike.Equipment.Handlebar.HandlebarName,
                        HandlebarQuantity = bike.Equipment.Handlebar.HandlebarQuantity
                    },
                    Saddle = new Saddle
                    {
                        SaddleName = bike.Equipment.Saddle.SaddleName,
                        SaddleQuantity = bike.Equipment.Saddle.SaddleQuantity
                    },
                    SeatPost = new SeatPost
                    {
                        SeatPostName = bike.Equipment.SeatPost.SeatPostName,
                        SeatPostQuantity = bike.Equipment.SeatPost.SeatPostQuantity
                    },
                    Steering = new Steering
                    {
                        SteeringName = bike.Equipment.Steering.SteeringName,
                    },
                    Stem = new Stem
                    {
                        StemName = bike.Equipment.Stem.StemName,
                        StemQuantity = bike.Equipment.Stem.StemQuantity
                    }
                },
                TypeOfBike = bike.TypeOfBike
            };

            return View(bikeVM);
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
                    Frameset = new Frameset
                    {
                        BikeSize = new BikeSize
                        {
                            BikeSizeName = bikeVM.Frameset.BikeSize.BikeSizeName
                        },
                        Frame = new Frame 
                        {
                            FrameName = bikeVM.Frameset.Frame.FrameName,
                            FrameDescription = bikeVM.Frameset.Frame.FrameDescription,
                            FrameQuantity = bikeVM.Frameset.Frame.FrameQuantity
                        },
                        Fork = new Fork
                        {
                            ForkName = bikeVM.Frameset.Fork.ForkName,
                            ForkDescription = bikeVM.Frameset.Fork.ForkDescription,
                            ForkQuantity = bikeVM.Frameset.Fork.ForkQuantity
                        }
                    },
                    Wheelset = new Wheelset
                    {
                        Tire = new Tire
                        {
                            TireName = bikeVM.Wheelset.Tire.TireName,
                            TireDescription = bikeVM.Wheelset.Tire.TireDescription,
                            TireQuantity = bikeVM.Wheelset.Tire.TireQuantity
                        },
                        Rim = new Rim
                        {
                            RimName = bikeVM.Wheelset.Rim.RimName,
                            RimDescription = bikeVM.Wheelset.Rim.RimDescription,
                            RimQuantity = bikeVM.Wheelset.Rim.RimQuantity
                        },
                        Hub = new Hub
                        {
                            HubName = bikeVM.Wheelset.Hub.HubName,
                            HubDescription = bikeVM.Wheelset.Hub.HubDescription,
                            HubQuantity = bikeVM.Wheelset.Hub.HubQuantity
                        }
                    },
                    Groopset = new Groopset
                    {
                        Transmition = new Transmition 
                        { 
                            Cassette = new Cassette
                            {
                                CassetteName = bikeVM.Groopset.Transmition.Cassette.CassetteName,
                                CassetteQuantity = bikeVM.Groopset.Transmition.Cassette.CassetteQuantity
                            },
                            Switch = new Switch
                            {
                                SwitchName = bikeVM.Groopset.Transmition.Switch.SwitchName,
                                SwitchQuantity = bikeVM.Groopset.Transmition.Switch.SwitchQuantity
                            },
                            Shifter = new Shifter
                            {
                                ShifterName = bikeVM.Groopset.Transmition.Shifter.ShifterName,
                                ShifterQuantity = bikeVM.Groopset.Transmition.Shifter.ShifterQuantity
                            },
                            FrontGear = new FrontGear
                            {
                                FrontGearName = bikeVM.Groopset.Transmition.FrontGear.FrontGearName,
                                FrontGearQuantity = bikeVM.Groopset.Transmition.FrontGear.FrontGearQuantity
                            }
                        },
                        Carriage = new Carriage
                        {
                            CarriageName = bikeVM.Groopset.Carriage.CarriageName,
                            CarriageQuantity = bikeVM.Groopset.Carriage.CarriageQuantity
                        },
                        Pedals = new Pedals
                        {
                            PedalsName = bikeVM.Groopset.Pedals.PedalsName,
                            PedalsQuantity = bikeVM.Groopset.Pedals.PedalsQuantity
                        }
                    },
                    Equipment = new Equipment
                    {
                        Brake = new Brake
                        {
                            BrakeName = bikeVM.Equipment.Brake.BrakeName,
                            BrakeQuantity = bikeVM.Equipment.Brake.BrakeQuantity
                        },
                        Grips = new Grips
                        {
                            GripsName = bikeVM.Equipment.Grips.GripsName,
                            GripsQuantity = bikeVM.Equipment.Grips.GripsQuantity
                        },
                        Handlebar = new Handlebar
                        {
                            HandlebarName = bikeVM.Equipment.Handlebar.HandlebarName,
                            HandlebarQuantity = bikeVM.Equipment.Handlebar.HandlebarQuantity
                        },
                        Saddle = new Saddle
                        {
                            SaddleName = bikeVM.Equipment.Saddle.SaddleName,
                            SaddleQuantity = bikeVM.Equipment.Saddle.SaddleQuantity
                        },
                        SeatPost = new SeatPost
                        {
                            SeatPostName = bikeVM.Equipment.SeatPost.SeatPostName,
                            SeatPostQuantity = bikeVM.Equipment.SeatPost.SeatPostQuantity
                        },
                        Steering = new Steering
                        {
                            SteeringName = bikeVM.Equipment.Steering.SteeringName,
                        },
                        Stem = new Stem
                        {
                            StemName = bikeVM.Equipment.Stem.StemName,
                            StemQuantity = bikeVM.Equipment.Stem.StemQuantity
                        }
                    },
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

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditBikeViewModel bikeVM)
        {

            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit bike");
                return View("Edit", bikeVM);
            }

            var editBike = await _bikeRepository.GetByIdAsyncNoTracking(id);

            if (editBike != null)
            {
                try
                {
                    await _photoService.DeletePhotoAsync(editBike.BikeImage);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Could not delete photo");
                    return View(bikeVM);
                }

                var photoResult = await _photoService.AddPhotoAsync(bikeVM.BikeImage);

                var bike = new Bike
                {
                    BikeId = id,
                    BikeName = bikeVM.BikeName,
                    BikeImage = photoResult.Url.ToString(),
                    BikeDescription = bikeVM.BikeDescription,
                    BikePrice = bikeVM.BikePrice,
                    BikeWeight = bikeVM.BikeWeight,
                    Frameset = new Frameset
                    {
                        BikeSize = new BikeSize
                        {
                            BikeSizeName = bikeVM.Frameset.BikeSize.BikeSizeName
                        },
                        Frame = new Frame
                        {
                            FrameName = bikeVM.Frameset.Frame.FrameName,
                            FrameDescription = bikeVM.Frameset.Frame.FrameDescription,
                            FrameQuantity = bikeVM.Frameset.Frame.FrameQuantity
                        },
                        Fork = new Fork
                        {
                            ForkName = bikeVM.Frameset.Fork.ForkName,
                            ForkDescription = bikeVM.Frameset.Fork.ForkDescription,
                            ForkQuantity = bikeVM.Frameset.Fork.ForkQuantity
                        }
                    },
                    Wheelset = new Wheelset
                    {
                        Tire = new Tire
                        {
                            TireName = bikeVM.Wheelset.Tire.TireName,
                            TireDescription = bikeVM.Wheelset.Tire.TireDescription,
                            TireQuantity = bikeVM.Wheelset.Tire.TireQuantity
                        },
                        Rim = new Rim
                        {
                            RimName = bikeVM.Wheelset.Rim.RimName,
                            RimDescription = bikeVM.Wheelset.Rim.RimDescription,
                            RimQuantity = bikeVM.Wheelset.Rim.RimQuantity
                        },
                        Hub = new Hub
                        {
                            HubName = bikeVM.Wheelset.Hub.HubName,
                            HubDescription = bikeVM.Wheelset.Hub.HubDescription,
                            HubQuantity = bikeVM.Wheelset.Hub.HubQuantity
                        }
                    },
                    Groopset = new Groopset
                    {
                        Transmition = new Transmition
                        {
                            Cassette = new Cassette
                            {
                                CassetteName = bikeVM.Groopset.Transmition.Cassette.CassetteName,
                                CassetteQuantity = bikeVM.Groopset.Transmition.Cassette.CassetteQuantity
                            },
                            Switch = new Switch
                            {
                                SwitchName = bikeVM.Groopset.Transmition.Switch.SwitchName,
                                SwitchQuantity = bikeVM.Groopset.Transmition.Switch.SwitchQuantity
                            },
                            Shifter = new Shifter
                            {
                                ShifterName = bikeVM.Groopset.Transmition.Shifter.ShifterName,
                                ShifterQuantity = bikeVM.Groopset.Transmition.Shifter.ShifterQuantity
                            },
                            FrontGear = new FrontGear
                            {
                                FrontGearName = bikeVM.Groopset.Transmition.FrontGear.FrontGearName,
                                FrontGearQuantity = bikeVM.Groopset.Transmition.FrontGear.FrontGearQuantity
                            }
                        },
                        Carriage = new Carriage
                        {
                            CarriageName = bikeVM.Groopset.Carriage.CarriageName,
                            CarriageQuantity = bikeVM.Groopset.Carriage.CarriageQuantity
                        },
                        Pedals = new Pedals
                        {
                            PedalsName = bikeVM.Groopset.Pedals.PedalsName,
                            PedalsQuantity = bikeVM.Groopset.Pedals.PedalsQuantity
                        }
                    },
                    Equipment = new Equipment
                    {
                        Brake = new Brake
                        {
                            BrakeName = bikeVM.Equipment.Brake.BrakeName,
                            BrakeQuantity = bikeVM.Equipment.Brake.BrakeQuantity
                        },
                        Grips = new Grips
                        {
                            GripsName = bikeVM.Equipment.Grips.GripsName,
                            GripsQuantity = bikeVM.Equipment.Grips.GripsQuantity
                        },
                        Handlebar = new Handlebar
                        {
                            HandlebarName = bikeVM.Equipment.Handlebar.HandlebarName,
                            HandlebarQuantity = bikeVM.Equipment.Handlebar.HandlebarQuantity
                        },
                        Saddle = new Saddle
                        {
                            SaddleName = bikeVM.Equipment.Saddle.SaddleName,
                            SaddleQuantity = bikeVM.Equipment.Saddle.SaddleQuantity
                        },
                        SeatPost = new SeatPost
                        {
                            SeatPostName = bikeVM.Equipment.SeatPost.SeatPostName,
                            SeatPostQuantity = bikeVM.Equipment.SeatPost.SeatPostQuantity
                        },
                        Steering = new Steering
                        {
                            SteeringName = bikeVM.Equipment.Steering.SteeringName,
                        },
                        Stem = new Stem
                        {
                            StemName = bikeVM.Equipment.Stem.StemName,
                            StemQuantity = bikeVM.Equipment.Stem.StemQuantity
                        }
                    },
                    TypeOfBike = bikeVM.TypeOfBike
                };

                _bikeRepository.Update(bike);

                return RedirectToAction("Index");
            }
            else
            {
                return View(bikeVM);
            }
        }
    }
}
