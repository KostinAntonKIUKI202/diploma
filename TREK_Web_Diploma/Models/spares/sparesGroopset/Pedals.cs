using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesGroopset
{
    [Table( "Pedals",
            Schema = "sparesGroopset")]
    public class Pedals
    {
        //Модель для таблицы sparesGroopset.Pedals
        [Key]
        public int PedalsId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string PedalsName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int PedalsQuantity { get; set; }
    }
}
