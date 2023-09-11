using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesTransmition
{
    [Table( "Switch",
            Schema = "sparesTransmition")]
    public class Switch
    {
        //Модель для таблицы sparesTransmition.Switch
        [Key]
        public int SwitchId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(30)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string SwitchName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int SwitchQuantity { get; set; }
    }
}
