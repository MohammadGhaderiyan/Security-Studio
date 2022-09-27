using FluentValidation;

namespace SecurityStudio.Service.Base.Validator
{
    public class FluentValidationEntityValidatorService<T> : IEntityValidatorService<T> where T : SecurityStudio.Base.Main.Database.BaseEntity
    {
        private readonly AbstractValidator<T> _abstractValidator;

        public FluentValidationEntityValidatorService(AbstractValidator<T> abstractValidator)
        {
            _abstractValidator = abstractValidator;
        }

        public bool IsValid(T model)
        {
            return _abstractValidator.Validate(model).IsValid;
        }

        public void Dispose()
        {
        }
    }
}