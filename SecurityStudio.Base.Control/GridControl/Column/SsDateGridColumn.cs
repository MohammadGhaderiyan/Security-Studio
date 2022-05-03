using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsDateGridColumn : SsGridColumn
    {
        public SsDateGridColumn()
        {
            EditSettings = new DateEditSettings();
        }
    }
}