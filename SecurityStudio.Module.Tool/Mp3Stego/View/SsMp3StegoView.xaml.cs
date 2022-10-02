using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Mp3Stego.ViewModel;

namespace SecurityStudio.Module.Tool.Mp3Stego.View
{
    public partial class SsMp3StegoView : SsView
    {
        public SsMp3StegoView(SsMp3StegoViewModel ssMp3StegoViewModel)
            : base(ssMp3StegoViewModel)
        {
            InitializeComponent();
        }
    }
}