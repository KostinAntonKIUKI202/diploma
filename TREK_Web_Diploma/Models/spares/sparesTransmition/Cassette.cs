using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesTransmition
{
    [Table( "Cassette",
            Schema = "sparesTransmition")]
    public class Cassette
    {
        //Модель для таблицы sparesTransmition.Cassette
        [Key]
        public int CassetteId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string CassetteName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int CassetteQuantity { get; set; }
    }
}
