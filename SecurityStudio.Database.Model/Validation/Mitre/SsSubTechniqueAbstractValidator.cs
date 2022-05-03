using FluentValidation;
using SecurityStudio.Database.Model.Mitre;
using SecurityStudio.Database.Model.Validation.Infrastructure;

namespace SecurityStudio.Database.Model.Validation.Mitre
{
    public class SsSubTechniqueAbstractValidator : SsAbstractValidator<SubTechnique>
    {
        public SsSubTechniqueAbstractValidator()
        {
            RuleFor(subTechnique => subTechnique.Code).NotEmpty();
            RuleFor(subTechnique => subTechnique.Name).NotEmpty();
            RuleFor(subTechnique => subTechnique.TechniqueId).NotEmpty();
        }
    }
}