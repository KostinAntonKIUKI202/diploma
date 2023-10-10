using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesEquipment
{
    [Table( "Handlebar",
            Schema = "sparesEquipment")]
    public class Handlebar
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int HandlebarId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(128)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string HandlebarName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int HandlebarQuantity { get; set; }
    }
}
