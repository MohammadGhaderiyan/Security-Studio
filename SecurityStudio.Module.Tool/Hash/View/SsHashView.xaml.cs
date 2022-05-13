using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Hash.ViewModel;

namespace SecurityStudio.Module.Tool.Hash.View
{
    public partial class SsHashView : SsView
    {
        public SsHashView(SsHashViewModel ssHashViewModel)
            : base(ssHashViewModel)
        {
            InitializeComponent();
        }
    }
}