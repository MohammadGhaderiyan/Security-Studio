using SecurityStudio.Base.Control.Base;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsCodeIntGridColumn : SsIntGridColumn
    {
        public SsCodeIntGridColumn()
        {
            Header = "Code";
            // ReSharper disable once VirtualMemberCallInConstructor
            FieldName = "Code";
            GridColumnWidthType = GridColumnWidthType.Small;
        }
    }
}