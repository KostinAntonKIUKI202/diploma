using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesGroopset
{
    public class Carriage
    {
        //Модель для таблицы sparesGroopset.Carriage
        [Key]
        public int CarriageId { get; set; }
        public string CarriageName { get; set; }
        public int CarriageQuantity { get; set; }
    }
}
