using System.Windows;
using DevExpress.Xpf.Grid;

namespace SecurityStudio.Base.Control.Tree
{
    public class SsTreeListControl : TreeListControl
    {
        public SsTreeListControl()
        {
            SelectionMode = MultiSelectMode.Row;
            Margin = new Thickness(0);
        }
    }
}