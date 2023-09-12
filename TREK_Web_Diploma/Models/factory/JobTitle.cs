using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.factory
{
    [Table( "JobTitle", 
            Schema = "factory")]
    public class JobTitle
    {
        //Модель для таблицы factory.JobTitle
        
        [Key]
        public int JobTitleId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string JobTitleName { get; set; }
    }
}
