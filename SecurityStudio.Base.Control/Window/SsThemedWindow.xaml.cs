using DevExpress.Xpf.Core;
using SecurityStudio.Base.Main.Mvvm;

namespace SecurityStudio.Base.Control.Window
{
    public partial class SsThemedWindow : ThemedWindow
    {
        public SsThemedWindow()
        {
            InitializeComponent();
        }

        public void SetContent(SsView ssView)
        {
            SsContentControlMain.Content = ssView;
        }
    }
}