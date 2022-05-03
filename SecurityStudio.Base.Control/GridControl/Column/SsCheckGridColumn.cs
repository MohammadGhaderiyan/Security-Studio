using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsCheckGridColumn : SsGridColumn
    {
        public SsCheckGridColumn()
        {
            EditSettings = new CheckEditSettings();
        }
    }
}