using FluentValidation;

namespace core.lab2.Models
{
    public class WebsiteCreateModelValidator : AbstractValidator<WebsiteCreateModel>
    {
        public WebsiteCreateModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Url).NotEmpty();
        }
    }
}
