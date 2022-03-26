namespace CustomerSupport.Models.ViewModels
{
    public class CreateEnquireVM
    {
        
        public CreateEnquireVM()
        {
            EnquireTypes = new List<string>() { "Satisfy", "Complain","General" };
        }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string InquiryType { get; set; }
        public string Description { get; set; }
        public bool AgreeTerms { get; set; }

        public List<string> EnquireTypes { get; set; }
    }
}
