using practice_TrekCompany.Models.spares.sparesGroopset;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using practice_TrekCompany.Models.spares.sparesFrameset;

namespace practice_TrekCompany.Models.production
{
    [Table( "Frameset",
            Schema = "production")]
    public class Frameset
    {
        [Key]
        public int FramesetId { get; set; }
        
        [ForeignKey("Frame")]
        public int FrameId { get; set; }
        public Frame Frame { get; set; }
        
        [ForeignKey("Fork")]
        public int ForkId { get; set; }
        public Fork Fork { get; set; }
    }
}
