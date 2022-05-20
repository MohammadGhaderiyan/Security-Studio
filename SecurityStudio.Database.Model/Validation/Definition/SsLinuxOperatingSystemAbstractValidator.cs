using FluentValidation;
using SecurityStudio.Database.Model.Definition;
using SecurityStudio.Database.Model.Validation.Infrastructure;

namespace SecurityStudio.Database.Model.Validation.Definition
{
    public class SsLinuxOperatingSystemAbstractValidator : SsAbstractValidator<LinuxOperatingSystem>
    {
        public SsLinuxOperatingSystemAbstractValidator()
        {
            Include(new SsOperatingSystemAbstractValidator());
            RuleFor(operatingSystem => operatingSystem.SshPort).NotEmpty();
            RuleFor(operatingSystem => operatingSystem.SshUserName).NotEmpty();
            RuleFor(operatingSystem => operatingSystem.SshPassword).NotEmpty();
        }
    }
}