using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.Text
{
    public class SsTelephoneTextEdit : SsTextEdit
    {
        public SsTelephoneTextEdit()
        {
            MaskType = MaskType.Simple;
            Mask = "00000000000";
        }
    }
}