using practice_TrekCompany.Models.spares.sparesGroopset;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace practice_TrekCompany.Models.production
{
    [Table( "GroopSet",
            Schema = "production")]
    public class Groopset
    {
        [Key]
        public int GroopsetId { get; set; }
        
        [ForeignKey("Transmition")]
        public int TransmitionId { get; set; }
        public Transmition Transmition { get; set; }
        
        [ForeignKey("Carriage")]
        public int CarriageId { get; set; }
        public Carriage Carriage { get; set; }
        
        [ForeignKey("Pedals")]
        public int PedalsId { get; set; }
        public Pedals Pedals { get; set; }
    }
}
