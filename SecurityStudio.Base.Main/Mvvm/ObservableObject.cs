using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SecurityStudio.Base.Main.Mvvm
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var propertyChangedEventHandler = PropertyChanged;
            if (propertyChangedEventHandler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                propertyChangedEventHandler(this, e);
            }
        }
    }
}