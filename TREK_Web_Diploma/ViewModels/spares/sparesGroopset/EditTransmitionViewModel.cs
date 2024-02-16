using TREK_Web_Diploma.Models.spares.sparesTransmition;

namespace TREK_Web_Diploma.ViewModels.spares.sparesGroopset
{
    public class EditTransmitionViewModel
    {
        public int TransmitionId { get; set; }
        public int CassetteId { get; set; }
        public Cassette Cassette { get; set; }
        public int SwitchId { get; set; }
        public Switch Switch { get; set; }
        public int ShifterId { get; set; }
        public Shifter Shifter { get; set; }
        public int FrontGearId { get; set; }
        public FrontGear FrontGear { get; set; }
    }
}
