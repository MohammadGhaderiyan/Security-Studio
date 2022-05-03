using System.ComponentModel;
using SecurityStudio.Database.Model.Infrastructure;
using SecurityStudio.Database.Model.Validation.Mitre;

namespace SecurityStudio.Database.Model.Mitre
{
    /// <summary>
    /// Sub Technique
    /// </summary>
    public class SubTechnique : ModelBase, IDataErrorInfo
    {
        public SubTechnique()
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
        /// Technique
        /// </summary>
        private Technique _technique;
        public Technique Technique
        {
            get => _technique;
            set
            {
                _technique = value;
                OnPropertyChanged();
            }
        }

        private int _techniqueId;
        public int TechniqueId
        {
            get => _techniqueId;
            set
            {
                _techniqueId = value;
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

        private readonly SsSubTechniqueAbstractValidator _ssSubTechniqueAbstractValidator = new SsSubTechniqueAbstractValidator();

        public override string ValidateProperty(string propertyName)
        {
            return _ssSubTechniqueAbstractValidator.ValidateProperty(this, propertyName);
        }

        public override string ToString()
        {
            return $"{Code}- {Name}";
        }
    }
}