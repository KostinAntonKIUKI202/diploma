using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesTransmition
{
    public class Switch
    {
        //Модель для таблицы sparesTransmition.Switch
        [Key]
        public int SwitchId { get; set; }
        public string SwitchName { get; set; }
    }
}
