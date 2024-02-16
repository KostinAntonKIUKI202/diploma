using TREK_Web_Diploma.Models.spares.sparesGroopset;

namespace TREK_Web_Diploma.ViewModels.production
{
    public class EditGroopsetViewModel
    {
        public int GroopsetId { get; set; }
        public int TransmitionId { get; set; }
        public Transmition Transmition { get; set; }
        public int CarriageId { get; set; }
        public Carriage Carriage { get; set; }
        public int PedalsId { get; set; }
        public Pedals Pedals { get; set; }
    }
}
