using System.ComponentModel;
using SecurityStudio.Database.Model.Infrastructure;
using SecurityStudio.Database.Model.Validation.Definition;

namespace SecurityStudio.Database.Model.Definition
{
    /// <summary>
    /// User
    /// </summary>
    public class User : ModelBase, IDataErrorInfo
    {
        public User()
        {
        }

        /// <summary>
        /// Code
        /// </summary>
        private int _code;
        public int Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// First Name
        /// </summary>
        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Last Name
        /// </summary>
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
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

        private readonly SsUserAbstractValidator _ssUserAbstractValidator = new SsUserAbstractValidator();

        public override string ValidateProperty(string propertyName)
        {
            return _ssUserAbstractValidator.ValidateProperty(this, propertyName);
        }

        public override string ToString()
        {
            return $"{Code}- {FirstName} {LastName}";
        }
    }
}