using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesEquipment
{
    [Table( "Brake",
            Schema = "sparesEquipment")]
    public class Brake
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int BrakeId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string BrakeName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int BrakeQuantity { get; set; }
    }
}
