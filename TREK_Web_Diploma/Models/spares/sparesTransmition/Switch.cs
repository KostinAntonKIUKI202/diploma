using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesTransmition
{
    [Table( "Switch",
            Schema = "sparesTransmition")]
    public class Switch
    {
        //Модель для таблицы sparesTransmition.Switch
        [Key]
        public int SwitchId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string SwitchName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int SwitchQuantity { get; set; }
    }
}
