using System.ComponentModel.DataAnnotations;

namespace practice_TrekCompany.Models.spares.sparesFrameset
{
    public class Frame
    {
        //Модель для таблицы sparesFrameset.Frame
        [Key]
        public int FrameId { get; set; }
        public string FrameName { get; set; }
        public string FrameDescription { get; set; }
        public int FrameQuantity { get; set; }
    }
}
