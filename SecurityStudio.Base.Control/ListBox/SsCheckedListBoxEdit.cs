using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.ListBox
{
    public class SsCheckedListBoxEdit : SsListBoxEdit
    {
        public SsCheckedListBoxEdit()
        {
            StyleSettings = new CheckedListBoxEditStyleSettings();
        }
    }
}