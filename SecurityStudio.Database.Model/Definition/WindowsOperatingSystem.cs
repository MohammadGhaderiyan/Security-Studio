using SecurityStudio.Database.Model.Validation.Definition;

namespace SecurityStudio.Database.Model.Definition
{
    /// <summary>
    /// Windows
    /// </summary>
    public class WindowsOperatingSystem : OperatingSystem
    {
        public WindowsOperatingSystem()
        {
        }

        private readonly SsWindowsOperatingSystemAbstractValidator _ssWindowsOperatingSystemAbstractValidator = new SsWindowsOperatingSystemAbstractValidator();

        public override string ValidateProperty(string propertyName)
        {
            return _ssWindowsOperatingSystemAbstractValidator.ValidateProperty(this, propertyName);
        }
    }
}