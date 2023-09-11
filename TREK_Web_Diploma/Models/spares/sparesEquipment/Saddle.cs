using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    [Table( "Saddle",
            Schema = "sparesEquipment")]
    public class Saddle
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int SaddleId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(40)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string SaddleName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int SaddleQuantity { get; set; }
    }
}
