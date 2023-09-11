using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class Steering
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int SteeringId { get; set; }
        public string SteeringName { get; set; }
    }
}
