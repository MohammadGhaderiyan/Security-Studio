using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.Spin
{
    public class SsCurrencyIntSpinEdit : SsIntSpinEdit
    {
        public SsCurrencyIntSpinEdit()
        {
            MaskType = MaskType.Numeric;
            Mask = "###,###,##0,### ریال";
            MaskUseAsDisplayFormat = true;
        }
    }
}