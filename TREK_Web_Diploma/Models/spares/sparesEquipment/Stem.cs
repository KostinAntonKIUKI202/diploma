using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesEquipment
{
    public class Stem
    {
        //Модель для таблицы sparesEquipment.Brake
        [Key]
        public int StemId { get; set; }
        public string StemName { get; set; }
    }
}
