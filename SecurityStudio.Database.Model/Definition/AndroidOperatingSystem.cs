using SecurityStudio.Database.Model.Validation.Definition;

namespace SecurityStudio.Database.Model.Definition
{
    /// <summary>
    /// Android
    /// </summary>
    public class AndroidOperatingSystem : OperatingSystem
    {
        public AndroidOperatingSystem()
        {
        }

        private readonly SsAndroidOperatingSystemAbstractValidator _ssAndroidOperatingSystemAbstractValidator = new SsAndroidOperatingSystemAbstractValidator();

        public override string ValidateProperty(string propertyName)
        {
            return _ssAndroidOperatingSystemAbstractValidator.ValidateProperty(this, propertyName);
        }
    }
}