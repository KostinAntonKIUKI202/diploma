using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesEquipment
{
    [Table( "Grips",
            Schema = "sparesEquipment")]
    public class Grips
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int GripsId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string GripsName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int GripsQuantity { get; set; }
    }
}
