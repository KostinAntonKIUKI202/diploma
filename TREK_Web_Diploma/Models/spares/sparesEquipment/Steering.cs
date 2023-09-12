using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TREK_Web_Diploma.Models.spares.sparesEquipment
{
    [Table( "Steering",
            Schema = "sparesEquipment")]   
    
    public class Steering
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int SteeringId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string SteeringName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int SteeringQuantity { get; set; }
    }
}
