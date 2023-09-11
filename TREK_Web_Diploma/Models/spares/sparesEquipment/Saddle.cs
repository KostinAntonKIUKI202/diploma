using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class Saddle
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int SaddleId { get; set; }
        public string SaddleName { get; set; }

    }
}
