using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.factory
{
    [Table( "Staff",
            Schema = "factory")]
    public class Staff
    {
        //Модель для таблицы factory.Staff
        [Key]
        public int StaffId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(32)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string FirstName { get; set; }
        
        [DataType(DataType.Text)]
        [StringLength(32)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string SecondName { get; set; }
        //Подключение модели
        [ForeignKey("Factory")]
        public int FactoryId { get; set; }
        public Factory Factory { get; set; }
        //Подключение модели
        [ForeignKey("JobTitle")]
        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}
