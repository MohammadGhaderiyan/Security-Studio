using DevExpress.Xpf.Grid;

namespace SecurityStudio.Base.Control.GridControl
{
    public class SsEditableGridControl : SsGridControl
    {
        public SsEditableGridControl()
        {
            var ssTableView = (SsTableView)View;
            ssTableView.AllowEditing = true;
            ssTableView.NavigationStyle = GridViewNavigationStyle.Cell;
        }
    }
}