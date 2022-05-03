using FluentValidation;

namespace SecurityStudio.Database.Model.Validation.Infrastructure
{
    public class SsAbstractValidator<T> : AbstractValidator<T> where T : class
    {
        public string? ValidateProperty(T model, string propertyName)
        {
            var validationFailure = Validate(model).Errors
                .FirstOrDefault(item => item.PropertyName == propertyName);

            if (validationFailure != null)
                return validationFailure.ErrorMessage;

            return null;
        }

        public bool IsValid(T model)
        {
            return Validate(model).IsValid;
        }
    }
}