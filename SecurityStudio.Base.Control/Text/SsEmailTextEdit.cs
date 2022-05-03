using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.Text
{
    public class SsEmailTextEdit : SsTextEdit
    {
        public SsEmailTextEdit()
        {
            MaskType = MaskType.RegEx;
            Mask = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}";
            MaskIgnoreBlank = true;
        }
    }
}