using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TREK_Web_Diploma.Data.Enum;
using TREK_Web_Diploma.Models.production;

namespace TREK_Web_Diploma.ViewModels
{
    public class CreateBikeViewModel
    {
        [Key]
        public int BikeId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string BikeName { get; set; }

        public IFormFile BikeImage { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(2048)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string BikeDescription { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int BikePrice { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public double BikeWeight { get; set; }

        [ForeignKey("Frameset")]
        public int FramesetId { get; set; }
        public Frameset Frameset { get; set; }

        [ForeignKey("Wheelset")]
        public int WheelsetId { get; set; }
        public Wheelset Wheelset { get; set; }

        [ForeignKey("Groopset")]
        public int GroopsetId { get; set; }
        public Groopset Groopset { get; set; }

        [ForeignKey("Equipment")]
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }

        public TypeOfBike TypeOfBike { get; set; }

    }
}
