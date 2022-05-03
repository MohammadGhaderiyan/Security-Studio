using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsDoubleGridColumn : SsGridColumn
    {
        public SsDoubleGridColumn()
        {
            EditSettings = new SpinEditSettings
            {
                IsFloatValue = true
            };
        }
    }
}