using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesFrameset
{
    public class Fork
    {
        //Модель для таблицы sparesFrameset.Fork
        [Key]
        public int ForkId { get; set; }
        public string ForkName { get; set; }
        public string ForkDescription { get; set; }
        public int ForkQuantity { get; set; }
    }
}
