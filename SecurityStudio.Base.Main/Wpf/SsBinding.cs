using System.Windows.Data;

namespace SecurityStudio.Base.Main.Wpf
{
    public class SsBinding : Binding
    {
        public SsBinding()
        {
            Mode = BindingMode.TwoWay;
            UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            ValidatesOnDataErrors = true;
        }
    }
}