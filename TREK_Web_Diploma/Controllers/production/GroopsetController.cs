using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.factory;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.Models.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesTransmition;
using TREK_Web_Diploma.ViewModels.production;

namespace TREK_Web_Diploma.Controllers.production
{
    public class GroopsetController : Controller
    {
        private readonly IGroopsetRepository groopsetRepository;
        public GroopsetController(IGroopsetRepository groopsetReposiotory)
        {
            this.groopsetRepository = groopsetReposiotory;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Groopset> groopsets = await groopsetRepository.GetAll();
            return View(groopsets);
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
            var groopset = await groopsetRepository.GetByIdAsync(id);
            if (groopset == null) return View("Error");
            var groopsetVM = new EditGroopsetViewModel()
            {
                GroopsetId = groopset.GroopsetId,
                Transmition = new Transmition
                {
                    Cassette = new Cassette
                    {
                        CassetteName = groopset.Transmition.Cassette.CassetteName,
                        CassetteQuantity = groopset.Transmition.Cassette.CassetteQuantity
                    },
                    Switch = new Switch
                    {
                        SwitchName = groopset.Transmition.Switch.SwitchName,
                        SwitchQuantity = groopset.Transmition.Switch.SwitchQuantity
                    },
                    Shifter = new Shifter
                    {
                        ShifterName = groopset.Transmition.Shifter.ShifterName,
                        ShifterQuantity = groopset.Transmition.Shifter.ShifterQuantity
                    },
                    FrontGear = new FrontGear
                    {
                        FrontGearName = groopset.Transmition.FrontGear.FrontGearName,
                        FrontGearQuantity = groopset.Transmition.FrontGear.FrontGearQuantity
                    }
                },
                Carriage = new Carriage
                {
                    CarriageName = groopset.Carriage.CarriageName,
                    CarriageQuantity = groopset.Carriage.CarriageQuantity
                },
                Pedals = new Pedals
                {
                    PedalsName = groopset.Pedals.PedalsName,
                    PedalsQuantity = groopset.Pedals.PedalsQuantity
                }
            };
            return View(groopsetVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Groopset groopset)
        {
            if (!ModelState.IsValid)
            {
                return View(groopset);
            }
            groopsetRepository.Add(groopset);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Groopset groopset)
        {
            groopsetRepository.Add(groopset);
            return RedirectToAction("CreateById");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditGroopsetViewModel groopsetVM)
        {
            if (!ModelState.IsValid) 
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", groopsetVM);
            }
            var editGroopset = await groopsetRepository.GetByIdAsyncNoTracking(id);
            if (editGroopset != null)
            {
                var groopset = new Groopset
                {
                    GroopsetId = id,
                    Transmition = new Transmition
                    {
                        Cassette = new Cassette
                        {
                            CassetteName = groopsetVM.Transmition.Cassette.CassetteName,
                            CassetteQuantity = groopsetVM.Transmition.Cassette.CassetteQuantity
                        },
                        Switch = new Switch
                        {
                            SwitchName = groopsetVM.Transmition.Switch.SwitchName,
                            SwitchQuantity = groopsetVM.Transmition.Switch.SwitchQuantity
                        },
                        Shifter = new Shifter
                        {
                            ShifterName = groopsetVM.Transmition.Shifter.ShifterName,
                            ShifterQuantity = groopsetVM.Transmition.Shifter.ShifterQuantity
                        },
                        FrontGear = new FrontGear
                        {
                            FrontGearName = groopsetVM.Transmition.FrontGear.FrontGearName,
                            FrontGearQuantity = groopsetVM.Transmition.FrontGear.FrontGearQuantity
                        }
                    },
                    Carriage = new Carriage
                    {
                        CarriageName = groopsetVM.Carriage.CarriageName,
                        CarriageQuantity = groopsetVM.Carriage.CarriageQuantity
                    },
                    Pedals = new Pedals
                    {
                        PedalsName = groopsetVM.Pedals.PedalsName,
                        PedalsQuantity = groopsetVM.Pedals.PedalsQuantity
                    }
                };
                groopsetRepository.Update(groopset);
                return RedirectToAction("Index");
            }
            else
            {
                return View(groopsetVM);
            }
        }
    }
}
