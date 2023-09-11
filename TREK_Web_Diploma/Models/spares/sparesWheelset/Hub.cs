using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesWheelset
{
    [Table( "Hub",
            Schema = "sparesWheelset")]
    public class Hub
    {
        //Модель для таблицы sparesWheelset.Hub
        [Key]
        public int HubId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string HubName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(30)]
        [Required(AllowEmptyStrings = true)]
        public string HubDescription { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int HubQuantity { get; set; }
    }
}
