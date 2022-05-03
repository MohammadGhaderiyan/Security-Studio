using System.Windows;
using DevExpress.Xpf.Grid;

namespace SecurityStudio.Base.Control.Tree
{
    public class SsTreeListView : TreeListView
    {
        public SsTreeListView()
        {
            AllowEditing = false;
            ShowIndicator = false;
            ShowVerticalLines = false;
            ShowHorizontalLines = false;
            Margin = new Thickness(0);
        }
    }
}