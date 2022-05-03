using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.Text
{
    public class SsPostalCodeTextEdit : SsTextEdit
    {
        public SsPostalCodeTextEdit()
        {
            MaskType = MaskType.Simple;
            Mask = "0000000000";
        }
    }
}