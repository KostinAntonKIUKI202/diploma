using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class SeatPost
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int SeatPostId { get; set; }
        public string SeatPostName { get; set; }
    }
}
