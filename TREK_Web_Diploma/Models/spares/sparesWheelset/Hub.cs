using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesWheelset
{
    public class Hub
    {
        //Модель для таблицы sparesWheelset.Hub
        [Key]
        public int HubId { get; set; }
        public string HubName { get; set; }
        public string HubDescription { get; set; }
        public int HubQuantity { get; set; }
    }
}
