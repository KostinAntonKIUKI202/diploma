using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesWheelset
{
    [Table( "Tire",
            Schema = "sparesWheelset")]
    public class Tire
    {
        //Модель для таблицы sparesWheelset.Tire
        [Key]
        public int TireId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string TireName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(128)]
        [Required(AllowEmptyStrings = true)]
        public string TireDescription { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int TireQuantity { get; set; }
    }
}
