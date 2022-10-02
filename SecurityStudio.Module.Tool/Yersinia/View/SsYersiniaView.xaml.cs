using SecurityStudio.Base.Main.Mvvm;
using SecurityStudio.Module.Tool.Yersinia.ViewModel;

namespace SecurityStudio.Module.Tool.Yersinia.View
{
    public partial class SsYersiniaView : SsView
    {
        public SsYersiniaView(SsYersiniaViewModel ssYersiniaViewModel)
            : base(ssYersiniaViewModel)
        {
            InitializeComponent();
        }
    }
}