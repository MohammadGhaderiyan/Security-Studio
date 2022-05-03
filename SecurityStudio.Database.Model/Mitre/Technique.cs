using System.ComponentModel;
using SecurityStudio.Database.Model.Infrastructure;
using SecurityStudio.Database.Model.Validation.Mitre;

namespace SecurityStudio.Database.Model.Mitre
{
    /// <summary>
    /// Technique
    /// </summary>
    public class Technique : ModelBase, IDataErrorInfo
    {
        public Technique()
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
        /// Tactic
        /// </summary>
        private Tactic _tactic;
        public Tactic Tactic
        {
            get => _tactic;
            set
            {
                _tactic = value;
                OnPropertyChanged();
            }
        }

        private int _tacticId;
        public int TacticId
        {
            get => _tacticId;
            set
            {
                _tacticId = value;
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

        private readonly SsTechniqueAbstractValidator _ssTechniqueAbstractValidator = new SsTechniqueAbstractValidator();

        public override string ValidateProperty(string propertyName)
        {
            return _ssTechniqueAbstractValidator.ValidateProperty(this, propertyName);
        }

        public override string ToString()
        {
            return $"{Code}- {Name}";
        }
    }
}