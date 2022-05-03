using FluentValidation;
using SecurityStudio.Database.Model.Mitre;
using SecurityStudio.Database.Model.Validation.Infrastructure;

namespace SecurityStudio.Database.Model.Validation.Mitre
{
    public class SsTechniqueAbstractValidator : SsAbstractValidator<Technique>
    {
        public SsTechniqueAbstractValidator()
        {
            RuleFor(technique => technique.Code).NotEmpty();
            RuleFor(technique => technique.Name).NotEmpty();
            RuleFor(technique => technique.TacticId).NotEmpty();
        }
    }
}