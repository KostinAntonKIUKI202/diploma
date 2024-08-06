using Microsoft.AspNetCore.Mvc;
using TREK_Web_Diploma.Interfaces.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesGroopset;
using TREK_Web_Diploma.Models.spares.sparesTransmition;
using TREK_Web_Diploma.ViewModels.spares.sparesGroopset;

namespace TREK_Web_Diploma.Controllers.spares.sparesGroopset
{
    public class TransmitionController : Controller
    {
        private readonly ITransmitionRepository transmitionRepository;
        public TransmitionController(ITransmitionRepository transmitionRepository)
        {
            this.transmitionRepository = transmitionRepository;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Transmition> transmitions = await transmitionRepository.GetAll();
            return View(transmitions);
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
            var transmition = await transmitionRepository.GetByIdAsync(id);
            if (transmition == null) return View("Error");
            var transmitionVM = new EditTransmitionViewModel()
            {
                TransmitionId = transmition.TransmitionId,
                CassetteId = transmition.CassetteId,
                Cassette = new Cassette {
                    CassetteName = transmition.Cassette.CassetteName,
                    CassetteQuantity = transmition.Cassette.CassetteQuantity,
                },
                SwitchId = transmition.SwitchId,
                Switch = new Switch
                {
                    SwitchName = transmition.Switch.SwitchName,
                    SwitchQuantity = transmition.Switch.SwitchQuantity
                },
                ShifterId = transmition.ShifterId,
                Shifter = new Shifter
                {
                    ShifterName = transmition.Shifter.ShifterName,
                    ShifterQuantity = transmition.Shifter.ShifterQuantity
                },
                FrontGearId = transmition.FrontGearId,
                FrontGear = new FrontGear
                {
                    FrontGearName = transmition.FrontGear.FrontGearName,
                    FrontGearQuantity = transmition.FrontGear.FrontGearQuantity
                },
            };
            return View(transmitionVM);

        }
        [HttpPost]
        public async Task<IActionResult> Create(Transmition transmition)
        {
            if (!ModelState.IsValid)
            {
                return View(transmition);
            }
            transmitionRepository.Add(transmition);
            return RedirectToAction("Create");
        }

        [HttpPost]
        public async Task<IActionResult> CreateById(Transmition transmition)
        {
            transmitionRepository.Add(transmition);
            return RedirectToAction("CreateById");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditTransmitionViewModel transmitionVM)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit");
                return View("Edit", transmitionVM);
            }
            var editTransmition = await transmitionRepository.GetByIdAsyncNoTracking(id);
            if (editTransmition != null)
            {
                var transmition = new Transmition
                {
                    TransmitionId = transmitionVM.TransmitionId,
                    CassetteId = transmitionVM.CassetteId,
                    Cassette = new Cassette
                    {
                        CassetteName = transmitionVM.Cassette.CassetteName,
                        CassetteQuantity = transmitionVM.Cassette.CassetteQuantity,
                    },
                    SwitchId = transmitionVM.SwitchId,
                    Switch = new Switch
                    {
                        SwitchName = transmitionVM.Switch.SwitchName,
                        SwitchQuantity = transmitionVM.Switch.SwitchQuantity
                    },
                    ShifterId = transmitionVM.ShifterId,
                    Shifter = new Shifter
                    {
                        ShifterName = transmitionVM.Shifter.ShifterName,
                        ShifterQuantity = transmitionVM.Shifter.ShifterQuantity
                    },
                    FrontGearId = transmitionVM.FrontGearId,
                    FrontGear = new FrontGear
                    {
                        FrontGearName = transmitionVM.FrontGear.FrontGearName,
                        FrontGearQuantity = transmitionVM.FrontGear.FrontGearQuantity
                    },
                };
                transmitionRepository.Update(transmition);
                return RedirectToAction("Index");
            }
            else
            {
                return View(transmitionVM);
            }
        }
    }
}
