using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsDateTimeGridColumn : SsGridColumn
    {
        public SsDateTimeGridColumn()
        {
            EditSettings = new DateEditSettings
            {
                DisplayFormat = "MM/dd/yyyy hh:mm:ss"
            };
        }
    }
}