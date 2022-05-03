using SecurityStudio.Database.Model.Validation.Definition;

namespace SecurityStudio.Database.Model.Definition
{
    /// <summary>
    /// Linux
    /// </summary>
    public class LinuxOperatingSystem : OperatingSystem
    {
        public LinuxOperatingSystem()
        {
        }

        private readonly SsLinuxOperatingSystemAbstractValidator _ssLinuxOperatingSystemAbstractValidator = new SsLinuxOperatingSystemAbstractValidator();

        public override string ValidateProperty(string propertyName)
        {
            return _ssLinuxOperatingSystemAbstractValidator.ValidateProperty(this, propertyName);
        }
    }
}