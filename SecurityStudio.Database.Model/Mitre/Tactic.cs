using System.Collections.ObjectModel;
using SecurityStudio.Database.Model.Infrastructure;
using SecurityStudio.Database.Model.Validation.Mitre;

namespace SecurityStudio.Database.Model.Mitre
{
    /// <summary>
    /// Tactic
    /// </summary>
    public class Tactic : ModelBase
    {
        public Tactic()
        {
            Techniques = new ObservableCollection<Technique>();
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

        private ObservableCollection<Technique> _techniques;
        public ObservableCollection<Technique> Techniques
        {
            get => _techniques;
            set
            {
                _techniques = value;
                OnPropertyChanged();
            }
        }

        private readonly SsTacticAbstractValidator _ssTacticAbstractValidator = new SsTacticAbstractValidator();

        public override string ValidateProperty(string propertyName)
        {
            return _ssTacticAbstractValidator.ValidateProperty(this, propertyName);
        }

        public override string ToString()
        {
            return $"{Code}- {Name}";
        }
    }
}