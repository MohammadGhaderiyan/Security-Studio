using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsPercentDoubleGridColumn : SsGridColumn
    {
        public SsPercentDoubleGridColumn()
        {
            EditSettings = new SpinEditSettings
            {
                IsFloatValue = true,
                MaxValue = 100,
                MinValue = 0
            };
        }
    }
}