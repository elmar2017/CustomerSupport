using CustomerSupport.BLL.Models.Dtos;
using FluentValidation;

namespace CustomerSupport.Models.Validators
{
    public class EnquireValidator : AbstractValidator<CreateEnquireDto>
    {
        public EnquireValidator()
        {
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.PhoneNumber).NotNull().MinimumLength(1);
            RuleFor(x => x.InquiryType).NotNull();
            RuleFor(x => x.Description).NotNull();
            RuleFor(x => x.AgreeTerms).Equal(true);
        }
    }
}
