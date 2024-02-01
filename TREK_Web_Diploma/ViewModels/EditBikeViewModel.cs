using TREK_Web_Diploma.Data.Enum;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.ViewModels
{
    public class EditBikeViewModel
    {
        public int BikeId { get; set; }
        public string BikeName { get; set; }
        public IFormFile BikeImage { get; set; }
        public string? URL { get; set; }
        public string BikeDescription { get; set; }
        public int BikePrice { get; set; }
        public double BikeWeight { get; set; }
        public int FramesetId { get; set; }
        public Frameset Frameset { get; set; }
        public int WheelsetId { get; set; }
        public Wheelset Wheelset { get; set; }
        public int GroopsetId { get; set; }
        public Groopset Groopset { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
        public TypeOfBike TypeOfBike { get; set; }

    }
}
