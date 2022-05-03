using System.Windows;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Base.Control.UserControl
{
    public partial class SsAddEditDeleteUserControl : SsUserControl
    {
        public SsAddEditDeleteUserControl()
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
                typeof(SsAddEditDeleteUserControl), new PropertyMetadata(null));


        public SsCommand SsEditCommand
        {
            get => (SsCommand)GetValue(SsEditCommandProperty);
            set => SetValue(SsEditCommandProperty, value);
        }

        public static readonly DependencyProperty SsEditCommandProperty =
            DependencyProperty.Register("SsEditCommand", typeof(SsCommand),
                typeof(SsAddEditDeleteUserControl), new PropertyMetadata(null));


        public SsCommand SsDeleteCommand
        {
            get => (SsCommand)GetValue(SsDeleteCommandProperty);
            set => SetValue(SsDeleteCommandProperty, value);
        }

        public static readonly DependencyProperty SsDeleteCommandProperty =
            DependencyProperty.Register("SsDeleteCommand", typeof(SsCommand),
                typeof(SsAddEditDeleteUserControl), new PropertyMetadata(null));
    }
}