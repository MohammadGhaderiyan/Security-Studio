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

        /// <summary>
        /// SSH Port
        /// </summary>
        private int _sshPort;
        public int SshPort
        {
            get => _sshPort;
            set
            {
                _sshPort = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// SSH User Name
        /// </summary>
        private string _sshUserName;
        public string SshUserName
        {
            get => _sshUserName;
            set
            {
                _sshUserName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// SSH Password
        /// </summary>
        private string _sshPassword;
        public string SshPassword
        {
            get => _sshPassword;
            set
            {
                _sshPassword = value;
                OnPropertyChanged();
            }
        }

        private readonly SsLinuxOperatingSystemAbstractValidator _ssLinuxOperatingSystemAbstractValidator = new();

        public override string ValidateProperty(string propertyName)
        {
            return _ssLinuxOperatingSystemAbstractValidator.ValidateProperty(this, propertyName);
        }
    }
}