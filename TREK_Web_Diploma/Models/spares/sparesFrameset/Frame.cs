using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TREK_Web_Diploma.Models.spares.sparesFrameset
{
    [Table( "Frame",
            Schema = "sparesFrameset")]
    public class Frame
    {
        //Модель для таблицы sparesFrameset.Frame
        [Key]
        public int FrameId { get; set; }

        [DataType(DataType.Text)]
        [StringLength(64)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public string FrameName { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(256)]
        [Required(AllowEmptyStrings = true)]
        public string FrameDescription { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле має бути заповненим.")]
        public int FrameQuantity { get; set; }
    }
}
