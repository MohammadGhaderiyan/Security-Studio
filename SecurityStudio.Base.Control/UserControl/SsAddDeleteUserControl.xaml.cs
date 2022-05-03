using System.Windows;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Base.Control.UserControl
{
    public partial class SsAddDeleteUserControl : SsUserControl
    {
        public SsAddDeleteUserControl()
        {
            InitializeComponent();
        }


        public SsCommand SsAddCommand
        {
            get => (SsCommand)GetValue(SsAddCommandProperty);
            set => SetValue(SsAddCommandProperty, value);
        }

        public static readonly DependencyProperty SsAddCommandProperty =
            DependencyProperty.Register("SsAddCommand", typeof(SsCommand),
                typeof(SsAddDeleteUserControl), new PropertyMetadata(null));


        public SsCommand SsDeleteCommand
        {
            get => (SsCommand)GetValue(SsDeleteCommandProperty);
            set => SetValue(SsDeleteCommandProperty, value);
        }

        public static readonly DependencyProperty SsDeleteCommandProperty =
            DependencyProperty.Register("SsDeleteCommand", typeof(SsCommand),
                typeof(SsAddDeleteUserControl), new PropertyMetadata(null));
    }
}