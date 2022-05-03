using System.ComponentModel;
using System.Windows;

namespace SecurityStudio.Base.Main.Mvvm
{
    public class SsView : System.Windows.Controls.UserControl
    {
        public SsView()
        {
        }

        public SsView(SsViewModel ssViewModel)
        {
            FontSize = 13;
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContextChanged += OnDataContextChanged;
                Loaded += OnLoaded;
                SsViewModel = ssViewModel;
                DataContext = SsViewModel;
                SsViewModel.SsView = this;
            }
        }

        private Window _window;
        public Window Window
        {
            get => _window;
            set
            {
                _window = value;
                if (Window != null)
                    Window.Closing += (sender, args) => args.Cancel = SsViewModel.OnWindowClosing();
            }
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            SsViewLoaded();
            if (!DesignerProperties.GetIsInDesignMode(this))
                SsViewModel.SsViewLoaded();
        }

        public virtual void SsViewLoaded()
        {
        }

        public virtual void SsViewSetFocus()
        {
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            SsViewModel.Prepare();
        }

        public SsViewModel SsViewModel
        {
            get => (SsViewModel)GetValue(SsViewModelProperty);
            set => SetValue(SsViewModelProperty, value);
        }

        public static readonly DependencyProperty SsViewModelProperty =
            DependencyProperty.Register("SsViewModel", typeof(SsViewModel),
                typeof(SsView), new PropertyMetadata(null));
    }
}