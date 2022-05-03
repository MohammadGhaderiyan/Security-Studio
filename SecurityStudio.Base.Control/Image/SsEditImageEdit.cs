using DevExpress.Xpf.Editors;

namespace SecurityStudio.Base.Control.Image
{
    public class SsEditImageEdit : SsImageEdit
    {
        public SsEditImageEdit()
        {
            ShowMenu = true;
            ShowLoadDialogOnClickMode = ShowLoadDialogOnClickMode.Always;
        }
    }
}