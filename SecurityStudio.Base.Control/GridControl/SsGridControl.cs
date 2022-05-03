using System.Windows;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Xpf;

namespace SecurityStudio.Base.Control.GridControl
{
    public class SsGridControl : DevExpress.Xpf.Grid.GridControl
    {
        public SsGridControl()
        {
            View = new SsTableView();
            Margin = new Thickness(0);
        }


        public ICommand RowDoubleClickCommand
        {
            get => (ICommand)GetValue(RowDoubleClickCommandProperty);
            set => SetValue(RowDoubleClickCommandProperty, value);
        }

        public static readonly DependencyProperty RowDoubleClickCommandProperty =
            DependencyProperty.Register("RowDoubleClickCommand", typeof(ICommand),
                typeof(SsGridControl), new PropertyMetadata(null, RowDoubleClickCommandChangedCallback));

        private static void RowDoubleClickCommandChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
            {
                var ssGridControl = (SsGridControl)d;
                var ssTableView = (SsTableView)ssGridControl.View;
                var command = (ICommand)e.NewValue;
                ssTableView.RowDoubleClickCommand = new DelegateCommand<RowClickArgs>(args =>
                {
                    command.Execute(null);
                });
            }
        }
    }
}