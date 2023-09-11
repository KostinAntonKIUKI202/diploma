using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.factory
{
    [Table( "JobTitle", 
            Schema = "Stuff")]
    public class JobTitle
    {
        //Модель для таблицы factory.JobTitle
        
        [Key]
        public int JobTitleId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(50)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public string JobTitleName { get; set; }
    }
}
