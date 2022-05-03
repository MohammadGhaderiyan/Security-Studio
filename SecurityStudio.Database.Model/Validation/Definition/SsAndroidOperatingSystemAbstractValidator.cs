using SecurityStudio.Database.Model.Definition;
using SecurityStudio.Database.Model.Validation.Infrastructure;

namespace SecurityStudio.Database.Model.Validation.Definition
{
    public class SsAndroidOperatingSystemAbstractValidator : SsAbstractValidator<AndroidOperatingSystem>
    {
        public SsAndroidOperatingSystemAbstractValidator()
        {
            Include(new SsOperatingSystemAbstractValidator());
        }
    }
}