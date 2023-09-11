using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesTransmition
{
    [Table( "Shifter",
            Schema = "sparesTransmition")]
    public class Shifter
    {
        //Модель для таблицы sparesTransmition.Shifter
        [Key]
        public int ShifterId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(30)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string ShifterName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int ShifterQuantity { get; set; }
    }
}
