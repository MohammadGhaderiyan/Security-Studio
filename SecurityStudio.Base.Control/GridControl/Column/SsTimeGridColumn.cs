using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsTimeGridColumn : SsGridColumn
    {
        public SsTimeGridColumn()
        {
            EditSettings = new DateEditSettings
            {
                Mask = "T",
                MaskUseAsDisplayFormat = true
            };
        }
    }
}