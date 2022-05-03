using System.Windows;
using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.ComboBox
{
    public class SsCheckedComboBoxEdit : SsComboBoxEdit
    {
        public SsCheckedComboBoxEdit()
        {
            StyleSettings = new CheckedComboBoxStyleSettings();
            Margin = new Thickness(0);
        }
    }
}