using practice_TrekCompany.Models.spares.sparesGroopset;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using practice_TrekCompany.Models.spares.sparesWheelset;

namespace practice_TrekCompany.Models.production
{
    [Table( "Wheelset",
            Schema = "production")]
    public class Wheelset
    {
        [Key]
        public int WheelsetId { get; set; }
        
        [ForeignKey("Hub")]
        public int HubId { get; set; }
        public Hub Hub { get; set; }
        
        [ForeignKey("Rim")]
        public int RimId { get; set; }
        public Rim Rim { get; set; }
        
        [ForeignKey("Tire")]
        public int TireId { get; set; }
        public Tire Tire { get; set; }
    }
}
