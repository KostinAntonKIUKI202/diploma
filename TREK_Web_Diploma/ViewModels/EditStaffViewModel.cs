using TREK_Web_Diploma.Models.factory;

namespace TREK_Web_Diploma.ViewModels
{
    public class EditStaffViewModel
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int FactoryId { get; set; }
        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }

    }
}
