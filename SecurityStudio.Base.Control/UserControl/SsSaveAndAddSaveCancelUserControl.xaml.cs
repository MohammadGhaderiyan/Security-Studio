using System.Windows;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Base.Control.UserControl
{
    public partial class SsSaveAndAddSaveCancelUserControl : SsUserControl
    {
        public SsSaveAndAddSaveCancelUserControl()
        {
            InitializeComponent();
        }


        public SsCommand SsSaveAndAddCommand
        {
            get => (SsCommand)GetValue(SsSaveAndAddCommandProperty);
            set => SetValue(SsSaveAndAddCommandProperty, value);
        }

        public static readonly DependencyProperty SsSaveAndAddCommandProperty =
            DependencyProperty.Register("SsSaveAndAddCommand", typeof(SsCommand),
                typeof(SsSaveAndAddSaveCancelUserControl), new PropertyMetadata(null));


        public SsCommand SsSaveCommand
        {
            get => (SsCommand)GetValue(SsSaveCommandProperty);
            set => SetValue(SsSaveCommandProperty, value);
        }

        public static readonly DependencyProperty SsSaveCommandProperty =
            DependencyProperty.Register("SsSaveCommand", typeof(SsCommand),
                typeof(SsSaveAndAddSaveCancelUserControl), new PropertyMetadata(null));


        public SsCommand SsCancelCommand
        {
            get => (SsCommand)GetValue(SsCancelCommandProperty);
            set => SetValue(SsCancelCommandProperty, value);
        }

        public static readonly DependencyProperty SsCancelCommandProperty =
            DependencyProperty.Register("SsCancelCommand", typeof(SsCommand),
                typeof(SsSaveAndAddSaveCancelUserControl), new PropertyMetadata(null));
    }
}