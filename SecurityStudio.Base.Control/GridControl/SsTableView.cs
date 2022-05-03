using System.Windows;
using DevExpress.Xpf.Grid;

namespace SecurityStudio.Base.Control.GridControl
{
    public class SsTableView : TableView
    {
        public SsTableView()
        {
            AllowEditing = true;
            NavigationStyle = GridViewNavigationStyle.Row;
            ShowGroupPanel = false;
            ShowTotalSummary = true;
            ShowSearchPanelMode = ShowSearchPanelMode.Never;
            Margin = new Thickness(0);
        }
    }
}