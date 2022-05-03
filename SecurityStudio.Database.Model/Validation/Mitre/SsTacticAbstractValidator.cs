using FluentValidation;
using SecurityStudio.Database.Model.Mitre;
using SecurityStudio.Database.Model.Validation.Infrastructure;

namespace SecurityStudio.Database.Model.Validation.Mitre
{
    public class SsTacticAbstractValidator : SsAbstractValidator<Tactic>
    {
        public SsTacticAbstractValidator()
        {
            RuleFor(tactic => tactic.Code).NotEmpty();
            RuleFor(tactic => tactic.Name).NotEmpty();
        }
    }
}