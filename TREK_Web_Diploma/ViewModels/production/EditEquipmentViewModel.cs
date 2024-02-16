using TREK_Web_Diploma.Models.spares.sparesEquipment;

namespace TREK_Web_Diploma.ViewModels.production
{
    public class EditEquipmentViewModel
    {
        public int EquipmentId { get; set; }
        public int BrakeId { get; set; }
        public Brake Brake { get; set; }
        public int SaddleId { get; set; }
        public Saddle Saddle { get; set; }
        public int SeatPostId { get; set; }
        public SeatPost SeatPost { get; set; }
        public int StemId { get; set; }
        public Stem Stem { get; set; }
        public int HandlebarId { get; set; }
        public Handlebar Handlebar { get; set; }
        public int GripsId { get; set; }
        public Grips Grips { get; set; }
        public int SteeringId { get; set; }
        public Steering Steering { get; set; }
    }
}
