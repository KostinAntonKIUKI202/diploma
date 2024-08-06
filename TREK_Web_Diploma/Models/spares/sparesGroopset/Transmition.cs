using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.Models.spares.sparesGroopset
{
    [Table( "Transmition",
            Schema = "sparesGroopset")]
    public class Transmition
    {
        [Key]
        public int TransmitionId { get; set; }
        [ForeignKey("Cassette")]
        public int CassetteId { get; set; }
        public Cassette Cassette { get; set; }
        [ForeignKey("Switch")]
        public int SwitchId { get; set; }
        public Switch Switch { get; set; }
        [ForeignKey("Shifter")]
        public int ShifterId { get; set; }
        public Shifter Shifter { get; set; }
        [ForeignKey("FrontGear")]
        public int FrontGearId { get; set; }
        public FrontGear FrontGear { get; set; }

    }
}
