using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    [Table( "Stem",
            Schema = "sparesEquipment")]
    public class Stem
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int StemId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(40)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string StemName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int StemQuantity { get; set; }
    }
}
