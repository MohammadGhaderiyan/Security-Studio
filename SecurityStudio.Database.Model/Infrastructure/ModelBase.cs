using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SecurityStudio.Database.Model.Infrastructure
{
    /// <summary>
    /// Model Base
    /// </summary>
    public abstract class ModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public abstract string ValidateProperty(string propertyName);

        public string this[string columnName] => ValidateProperty(columnName);

        // ReSharper disable once UnassignedGetOnlyAutoProperty
        public string Error { get; }

        public abstract override string ToString();
    }
}