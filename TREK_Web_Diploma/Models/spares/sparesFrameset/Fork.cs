using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.spares.sparesFrameset
{
    [Table( "Fork",
            Schema = "sparesFrameset")]
    public class Fork
    {
        //Модель для таблицы sparesFrameset.Fork
        [Key]
        public int ForkId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string ForkName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(70)]
        [Required(AllowEmptyStrings = true)]
        public string ForkDescription { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int ForkQuantity { get; set; }
    }
}
