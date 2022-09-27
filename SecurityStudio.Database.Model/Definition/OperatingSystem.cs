using System.ComponentModel;
using SecurityStudio.Base.Main.Database;
using SecurityStudio.Database.Model.Validation.Definition;

namespace SecurityStudio.Database.Model.Definition
{
    /// <summary>
    /// Operating System
    /// </summary>
    public class OperatingSystem : BaseEntity, IDataErrorInfo
    {
        public OperatingSystem()
        {
        }

        /// <summary>
        /// Name
        /// </summary>
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// IP
        /// </summary>
        private string _ip;
        public string Ip
        {
            get => _ip;
            set
            {
                _ip = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Version
        /// </summary>
        private string _version;
        public string Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// User Name
        /// </summary>
        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Password
        /// </summary>
        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Enable
        /// </summary>
        private bool _enable;
        public bool Enable
        {
            get => _enable;
            set
            {
                _enable = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Description
        /// </summary>
        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        private readonly SsOperatingSystemAbstractValidator _ssOperatingSystemAbstractValidator = new();

        public override string ValidateProperty(string propertyName)
        {
            return _ssOperatingSystemAbstractValidator.ValidateProperty(this, propertyName);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}