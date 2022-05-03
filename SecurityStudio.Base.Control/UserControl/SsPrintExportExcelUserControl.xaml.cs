using System.Windows;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Base.Control.UserControl
{
    public partial class SsPrintExportExcelUserControl : SsUserControl
    {
        public SsPrintExportExcelUserControl()
        {
            InitializeComponent();
        }


        public SsCommand SsPrintCommand
        {
            get => (SsCommand)GetValue(SsPrintCommandProperty);
            set => SetValue(SsPrintCommandProperty, value);
        }

        public static readonly DependencyProperty SsPrintCommandProperty =
            DependencyProperty.Register("SsPrintCommand", typeof(SsCommand),
                typeof(SsPrintExportExcelUserControl), new PropertyMetadata(null));


        public SsCommand SsExportExcelCommand
        {
            get => (SsCommand)GetValue(SsExportExcelCommandProperty);
            set => SetValue(SsExportExcelCommandProperty, value);
        }

        public static readonly DependencyProperty SsExportExcelCommandProperty =
            DependencyProperty.Register("SsExportExcelCommand", typeof(SsCommand),
                typeof(SsPrintExportExcelUserControl), new PropertyMetadata(null));
    }
}