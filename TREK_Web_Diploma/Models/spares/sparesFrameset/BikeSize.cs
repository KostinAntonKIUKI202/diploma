using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesFrameset
{
    [Table( "BikeSize",
            Schema = "sparesFrameset")]
    public class BikeSize
    {
        [Key]
        public int BikeSizeId { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string BikeSizeName { get; set; }
    }
}
