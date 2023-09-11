using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.production
{
    [Table( "production",
            Schema = "TypeOfBike")]
    public class TypeOfBike
    {
        [Key]
        public int TypeOfBikeId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string TypeName { get; set; }
    }
}
