using FluentValidation;
using SecurityStudio.Database.Model.Validation.Infrastructure;

namespace SecurityStudio.Database.Model.Validation.Definition
{
    public class SsOperatingSystemAbstractValidator : SsAbstractValidator<Model.Definition.OperatingSystem>
    {
        public SsOperatingSystemAbstractValidator()
        {
            RuleFor(operatingSystem => operatingSystem.Code).NotEmpty();
            RuleFor(operatingSystem => operatingSystem.Name).NotEmpty();
        }
    }
}