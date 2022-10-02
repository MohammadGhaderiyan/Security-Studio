using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Pynput.ViewModel;

namespace SecurityStudio.Module.Tool.Pynput.View
{
    public partial class SsPynputView : SsView
    {
        public SsPynputView(SsPynputViewModel ssPynputViewModel)
            : base(ssPynputViewModel)
        {
            InitializeComponent();
        }
    }
}