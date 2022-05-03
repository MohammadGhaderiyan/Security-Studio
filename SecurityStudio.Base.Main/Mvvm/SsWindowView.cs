using System.ComponentModel;
using System.Windows;
using DevExpress.Xpf.Core;

namespace SecurityStudio.Base.Main.Mvvm
{
    public class SsWindowView : ThemedWindow
    {
        public SsWindowView()
        {
            FontSize = 13;
        }

        public SsWindowView(SsViewModel ssViewModel)
        {
            FontSize = 13;
            if (!DesignerProperties.GetIsInDesignMode(this))
            {
                DataContextChanged += OnDataContextChanged;
                Loaded += OnLoaded;
                SsViewModel = ssViewModel;
                DataContext = SsViewModel;
                SsViewModel.SsWindowView = this;
                Closing += (sender, args) => args.Cancel = SsViewModel.OnWindowClosing();
            }
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            LoadSsView();
            if (!DesignerProperties.GetIsInDesignMode(this))
                SsViewModel.SsViewLoaded();
        }

        public virtual void LoadSsView()
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
                typeof(SsWindowView), new PropertyMetadata(null));
    }
}