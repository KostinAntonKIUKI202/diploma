using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesTransmition
{
    [Table( "FrontGear",
            Schema = "sparesTransmition")]
    public class FrontGear
    {
        [Key]
        public int FrontGearId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string FrontGearName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int FrontGearQuantity { get; set; }
    }
}
