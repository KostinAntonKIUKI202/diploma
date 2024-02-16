using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.Models.production
{
    [Table( "Frameset",
            Schema = "production")]
    public class Frameset
    {
        [Key]
        public int FramesetId { get; set; }

        [ForeignKey("BikeSize")]
        public int BikeSizeId { get; set; }
        public BikeSize BikeSize { get; set; }

        [ForeignKey("Frame")]
        public int FrameId { get; set; }
        public Frame Frame { get; set; }
        
        [ForeignKey("Fork")]
        public int ForkId { get; set; }
        public Fork Fork { get; set; }
    }
}
