using SecurityStudio.Base.Control.Base;

namespace SecurityStudio.Base.Control.GridControl.Column
{
    public class SsEnableCheckGridColumn : SsCheckGridColumn
    {
        public SsEnableCheckGridColumn()
        {
            Header = "Enable";
            // ReSharper disable once VirtualMemberCallInConstructor
            FieldName = "Enable";
            GridColumnWidthType = GridColumnWidthType.Auto;
        }
    }
}