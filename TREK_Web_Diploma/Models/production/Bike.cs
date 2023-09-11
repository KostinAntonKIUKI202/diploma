using practice_TrekCompany.Models.spares.sparesEquipment;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.production
{
    [Table( "Bike",
            Schema = "production")]
    public class Bike
    {
        [Key]
        public int BikeId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(40)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public string BikeName { get; set; }

        [DataType(DataType.ImageUrl)]
        [StringLength(30)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public string BikeImage { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(2000)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public string BikeDescription { get; set; }

        [RegularExpression("([0-9]+)")]
        [StringLength(8)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public int BikePrice { get; set; }

        [StringLength(6)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public float BikeWeight { get; set; }

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
        
        [ForeignKey("TypeOfBike")]
        public int TypeOfBikeId { get; set; }
        public TypeOfBike TypeOfBike { get; set; }
    }
}
