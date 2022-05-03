using System.Windows;
using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.ComboBox
{
    public class SsRadioComboBoxEdit : SsComboBoxEdit
    {
        public SsRadioComboBoxEdit()
        {
            StyleSettings = new RadioComboBoxStyleSettings();
            Margin = new Thickness(0);
        }
    }
}