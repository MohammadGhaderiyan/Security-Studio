using FluentValidation;
using SecurityStudio.Database.Model.Definition;
using SecurityStudio.Database.Model.Validation.Infrastructure;

namespace SecurityStudio.Database.Model.Validation.Definition
{
    public class SsUserAbstractValidator : SsAbstractValidator<User>
    {
        public SsUserAbstractValidator()
        {
            RuleFor(user => user.Code).NotEmpty();
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.LastName).NotEmpty();
            RuleFor(user => user.UserName).NotEmpty();
            RuleFor(user => user.Password).NotEmpty();
        }
    }
}