using practice_TrekCompany.Models.spares.sparesGroopset;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using practice_TrekCompany.Models.spares.sparesEquipment;

namespace practice_TrekCompany.Models.production
{
    [Table( "Equipment",
            Schema = "production")]
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        
        [ForeignKey("Brake")]
        public int BrakeId { get; set; }
        public Brake Brake { get; set; }
        
        [ForeignKey("Saddle")]
        public int SaddleId { get; set; }
        public Saddle Saddle { get; set; }
        
        [ForeignKey("SeatPost")]
        public int SeatPostId { get; set; }
        public SeatPost SeatPost { get; set; }
        
        [ForeignKey("Stem")]
        public int StemId { get; set; }
        public Stem Stem { get; set; }
        
        [ForeignKey("Handlebar")]
        public int HandlebarId { get; set; }
        public Handlebar Handlebar { get; set; }
        
        [ForeignKey("Grips")]
        public int GripsId { get; set; }
        public Folk Grips { get; set; }
        
        [ForeignKey("Steering")]
        public int SteeringId { get; set; }
        public Steering Steering { get; set; }
    }
}
