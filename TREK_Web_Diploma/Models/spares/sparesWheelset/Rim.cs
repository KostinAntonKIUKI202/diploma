using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesWheelset
{
    public class Rim
    {
        //Модель для таблицы sparesWheelset.Rim
        [Key]
        public int RimId { get; set; }
        public string RimName { get; set; }
        public string RimDescription { get; set; }
        public int RimQuantity { get; set; }
    }
}
