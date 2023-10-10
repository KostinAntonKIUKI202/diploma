using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesWheelset
{
    [Table( "Hub",
            Schema = "sparesWheelset")]
    public class Hub
    {
        //Модель для таблицы sparesWheelset.Hub
        [Key]
        public int HubId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string HubName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = true)]
        public string HubDescription { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int HubQuantity { get; set; }
    }
}
