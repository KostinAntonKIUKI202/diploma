using TREK_Web_Diploma.Models.spares.sparesFrameset;

namespace TREK_Web_Diploma.ViewModels.production
{
    public class EditFramesetViewModel
    {
        public int FramesetId { get; set; }
        public int BikeSizeId { get; set; }
        public BikeSize BikeSize { get; set; }
        public int FrameId { get; set; }
        public Frame Frame { get; set; }
        public int ForkId { get; set; }
        public Fork Fork { get; set; }

    }
}
