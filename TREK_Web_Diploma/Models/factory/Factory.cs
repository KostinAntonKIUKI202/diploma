using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace practice_TrekCompany.Models.factory
{
    [Table( "Factory", 
            Schema = "factory")]
    public class Factory
    {
        //Модель для таблицы factory.Factory
        [Key]
        public int FactoryId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(30)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string City { get; set; }

        [DataType(DataType.Text)]
        [StringLength(30)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string Street { get; set; }

        [DataType(DataType.PostalCode)]
        [StringLength(6)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string ZipCode { get; set; }
    }
}
