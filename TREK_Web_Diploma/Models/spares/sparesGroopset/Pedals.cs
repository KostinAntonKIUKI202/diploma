using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesGroopset
{
    public class Pedals
    {
        //Модель для таблицы sparesGroopset.Pedals
        [Key]
        public int PedalsId { get; set; }
        public string PedalsName { get; set; }
        public int PedalsQuantity { get; set; }
    }
}
