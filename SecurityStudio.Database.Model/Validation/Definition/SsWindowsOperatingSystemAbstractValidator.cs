using SecurityStudio.Database.Model.Definition;
using SecurityStudio.Database.Model.Validation.Infrastructure;

namespace SecurityStudio.Database.Model.Validation.Definition
{
    public class SsWindowsOperatingSystemAbstractValidator : SsAbstractValidator<WindowsOperatingSystem>
    {
        public SsWindowsOperatingSystemAbstractValidator()
        {
            Include(new SsOperatingSystemAbstractValidator());
        }
    }
}