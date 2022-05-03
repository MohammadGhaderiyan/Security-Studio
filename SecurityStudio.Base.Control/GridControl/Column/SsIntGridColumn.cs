using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsIntGridColumn : SsGridColumn
    {
        public SsIntGridColumn()
        {
            EditSettings = new SpinEditSettings
            {
                IsFloatValue = false
            };
        }
    }
}