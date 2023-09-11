using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesTransmition
{
    public class Cassette
    {
        //Модель для таблицы sparesTransmition.Cassette
        [Key]
        public int CassetteId { get; set; }
        public string CassetteName { get; set; }

    }
}
