using System.Windows;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Base.Control.UserControl
{
    public partial class SsSaveCancelUserControl : SsUserControl
    {
        public SsSaveCancelUserControl()
        {
            InitializeComponent();
        }


        public SsCommand SsSaveCommand
        {
            get => (SsCommand)GetValue(SsSaveCommandProperty);
            set => SetValue(SsSaveCommandProperty, value);
        }

        public static readonly DependencyProperty SsSaveCommandProperty =
            DependencyProperty.Register("SsSaveCommand", typeof(SsCommand),
                typeof(SsSaveCancelUserControl), new PropertyMetadata(null));


        public SsCommand SsCancelCommand
        {
            get => (SsCommand)GetValue(SsCancelCommandProperty);
            set => SetValue(SsCancelCommandProperty, value);
        }

        public static readonly DependencyProperty SsCancelCommandProperty =
            DependencyProperty.Register("SsCancelCommand", typeof(SsCommand),
                typeof(SsSaveCancelUserControl), new PropertyMetadata(null));
    }
}