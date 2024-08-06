using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.production;
using TREK_Web_Diploma.Models.production;
using TREK_Web_Diploma.Models.spares.sparesWheelset;
using TREK_Web_Diploma.ViewModels.production;

namespace TREK_Web_Diploma.Controllers.production
{
    public class WheelsetController : Controller
    {
        private readonly IWheelsetRepository wheelsetRepository;
        public WheelsetController(IWheelsetRepository wheelset)
        {
            this.wheelsetRepository = wheelset;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Wheelset> wheelsets = await wheelsetRepository.GetAll();
            return View(wheelsets);
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
            var wheelset = await wheelsetRepository.GetByIdAsync(id);
            if (wheelset == null) return View("Error");
            var wheelsetVM = new EditWheelsetViewModel()
            {
                WheelsetId = wheelset.WheelsetId,
                Tire = new Tire
                {
                    TireName = wheelset.Tire.TireName,
                    TireDescription = wheelset.Tire.TireDescription,
                    TireQuantity = wheelset.Tire.TireQuantity
                },
                Rim = new Rim
                {
                    RimName = wheelset.Rim.RimName,
                    RimDescription = wheelset.Rim.RimDescription,
                    RimQuantity = wheelset.Rim.RimQuantity
                },
                Hub = new Hub
                {
                    HubName = wheelset.Hub.HubName,
                    HubDescription = wheelset.Hub.HubDescription,
                    HubQuantity = wheelset.Hub.HubQuantity
                }
            };
            return View(wheelsetVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Wheelset wheelset)
        {
            if (!ModelState.IsValid)
            {
                return View(wheelset);
            }
            wheelsetRepository.Add(wheelset);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Wheelset wheelset)
        {
            wheelsetRepository.Add(wheelset);
            return RedirectToAction("CreateById");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditWheelsetViewModel wheelsetVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", wheelsetVM);
            }

            var editWheelset = await wheelsetRepository.GetByIdAsyncNoTracking(id);
            if (editWheelset != null)
            {
                var wheelset = new Wheelset
                {
                    WheelsetId = id,
                    Tire = new Tire
                    {
                        TireName = wheelsetVM.Tire.TireName,
                        TireDescription = wheelsetVM.Tire.TireDescription,
                        TireQuantity = wheelsetVM.Tire.TireQuantity
                    },
                    Rim = new Rim
                    {
                        RimName = wheelsetVM.Rim.RimName,
                        RimDescription = wheelsetVM.Rim.RimDescription,
                        RimQuantity = wheelsetVM.Rim.RimQuantity
                    },
                    Hub = new Hub
                    {
                        HubName = wheelsetVM.Hub.HubName,
                        HubDescription = wheelsetVM.Hub.HubDescription,
                        HubQuantity = wheelsetVM.Hub.HubQuantity
                    }
                };

                wheelsetRepository.Update(wheelset);
                return RedirectToAction("Index");
            }
            else
            {
                return View(wheelsetVM);
            }
        }
    }
}
