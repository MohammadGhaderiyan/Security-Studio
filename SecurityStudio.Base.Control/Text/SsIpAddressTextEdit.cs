using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.Text
{
    public class SsIpAddressTextEdit : SsTextEdit
    {
        public SsIpAddressTextEdit()
        {
            MaskType = MaskType.RegEx;
            Mask = @"([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}";
        }
    }
}