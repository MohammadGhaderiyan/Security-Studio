using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsMemoGridColumn : SsGridColumn
    {
        public SsMemoGridColumn()
        {
            EditSettings = new MemoEditSettings();
        }
    }
}