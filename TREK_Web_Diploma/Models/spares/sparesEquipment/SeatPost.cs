using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    [Table( "SeatPost",
            Schema = "sparesEquipment")]
    public class SeatPost
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int SeatPostId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(40)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string SeatPostName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")] 
        public int SeatPostQuantity { get; set; }
    }
}
