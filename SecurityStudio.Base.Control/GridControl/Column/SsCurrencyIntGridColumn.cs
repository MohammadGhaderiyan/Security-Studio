using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.Settings;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsCurrencyIntGridColumn : SsIntGridColumn
    {
        public SsCurrencyIntGridColumn()
        {
            var spinEditSettings = (SpinEditSettings)EditSettings;
            spinEditSettings.MaskType = MaskType.Numeric;
            spinEditSettings.Mask = "###,###,###,##0 ریال";
            spinEditSettings.MaskUseAsDisplayFormat = true;
        }
    }
}