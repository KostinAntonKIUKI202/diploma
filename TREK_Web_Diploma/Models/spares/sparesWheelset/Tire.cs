using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesWheelset
{
    [Table( "Tire",
            Schema = "sparesWheelset")]
    public class Tire
    {
        //Модель для таблицы sparesWheelset.Tire
        [Key]
        public int TireId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string TireName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(40)]
        [Required(AllowEmptyStrings = true)]
        public string TireDescription { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int TireQuantity { get; set; }
    }
}
