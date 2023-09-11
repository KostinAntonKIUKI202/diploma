using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesWheelset
{
    public class Tire
    {
        //Модель для таблицы sparesWheelset.Tire
        [Key]
        public int TireId { get; set; }
        public string TireName { get; set; }
        public string TireDescription { get; set; }
        public int TireQuantity { get; set; }
    }
}
