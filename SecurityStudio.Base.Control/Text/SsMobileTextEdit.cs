using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.Text
{
    public class SsMobileTextEdit : SsTextEdit
    {
        public SsMobileTextEdit()
        {
            MaskType = MaskType.Simple;
            Mask = "00000000000";
        }
    }
}