using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsTextGridColumn : SsGridColumn
    {
        public SsTextGridColumn()
        {
            EditSettings = new TextEditSettings();
        }
    }
}