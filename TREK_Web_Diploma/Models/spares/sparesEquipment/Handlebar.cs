using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class Handlebar
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int HandlbarId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(40)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public string HandlbarName { get; set; }

        [DataType(DataType.Text)]
        [StringLength(4)]
        [Required(ErrorMessage = "Поле має бути заповненим.")]
        public int HandlebarQuantity { get; set; }
    }
}
