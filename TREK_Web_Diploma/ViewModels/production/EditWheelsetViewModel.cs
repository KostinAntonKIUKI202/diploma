using TREK_Web_Diploma.Models.spares.sparesWheelset;

namespace TREK_Web_Diploma.ViewModels.production
{
    public class EditWheelsetViewModel
    {
        public int WheelsetId { get; set; }
        public int HubId { get; set; }
        public Hub Hub { get; set; }
        public int RimId { get; set; }
        public Rim Rim { get; set; }
        public int TireId { get; set; }
        public Tire Tire { get; set; }
    }
}
